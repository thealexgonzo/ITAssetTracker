using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.MVC.Models.Asset;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.MVC.Controllers.MVC;

public class AssetController : Controller
{
    private IAssetService _assetService;
    private IModelService _modelService;

    public AssetController(IAssetService assetService, IModelService modelService)
    {
        _assetService = assetService;
        _modelService = modelService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        AssetList model = new();
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(AssetList model)
    {
        if(model.SearchTag is null)
        {
            Result<List<Asset>> result = _assetService.GetAll();
            if (result.Ok)
            {
                model.Assets = result.Data;
            }
            else
            {
                TempData["Alert"] = result.Message;
            }
        }
        else
        {
            Result<Asset> result = _assetService.GetByTag(model.SearchTag.Value);

            if (result.Ok)
            {
                model.Assets = [result.Data];
            }
            else
            {
                TempData["Alert"] = result.Message;
            }
        }

        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var model = new AssetForm();

        var result = _modelService.GetAll();

        if (result.Ok)
        {
            model.ModelsList = result.Data;
        }
        else
        {
            TempData["Alert"] = result.Message;
        }

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(AssetForm model)
    {
        if (ModelState.IsValid)
        {
            var entity = model.ToEntity();
            var result = _assetService.Add(entity);

            if (result.Ok)
            {
                TempData["Alert"] = result.Message;
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Alert"] = result.Message;
                return View(model);
            }
        }

        // Failed validation, return model.
        return View(model);
    }
}
