using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.MVC.Models.Asset;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.MVC.Controllers.MVC;

public class AssetController : Controller
{
    private IAssetService _assetService;
    private IModelService _modelService;
    private readonly ILogger _logger;

    public AssetController(IAssetService assetService, IModelService modelService, ILogger<AssetController> logger)
    {
        _assetService = assetService;
        _modelService = modelService;
        _logger = logger;
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

    /// <summary>
    /// Retrieves a list of available models from the underlying model service.
    /// </summary>
    /// <remarks>The returned list will never be null. If the model service fails to retrieve models, an empty
    /// list is returned instead.</remarks>
    /// <returns>A list of models if the retrieval operation succeeds; otherwise, an empty list.</returns>
    private List<Model>? RetrieveModelsList()
    {
        var result = _modelService.GetAll();

        if (!result.Ok)
        {
            return new List<Model>();            
        }

        return result.Data;
    }

    [HttpGet]
    public IActionResult Create()
    {
        var model = new AssetForm();
        model.ModelsList = RetrieveModelsList();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(AssetForm model)
    {
        if (ModelState.IsValid)
        {
            //model.ModelsList = RetrieveModelsList();
            Asset entity = model.ToEntity();
            Result result = _assetService.Add(entity);

            if (result.Ok)
            {
                TempData["Success"] = $"Asset with Tag # {model.Tag} created successfully.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Error"] = result.Message;
                return View(model);
            }
        }

        // Failed validation, return model.
        return View(model);
    }

    
}
