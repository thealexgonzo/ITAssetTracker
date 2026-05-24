using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;
using ITAssetTracker.MVC.Models.Asset;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.MVC.Controllers.MVC;

public class AssetController : Controller
{
    private IAssetService _assetService;
    private IAssetProductService _modelService;
    private IAssetStatusService _assetStatusService;
    private readonly ILogger _logger;

    public AssetController(IAssetService assetService, 
                           IAssetProductService modelService, 
                           IAssetStatusService assetStatusService,
                           ILogger<AssetController> logger)
    {
        _assetService = assetService;
        _modelService = modelService;
        _assetStatusService = assetStatusService;
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


    [HttpGet]
    public IActionResult Create()
    {
        var model = new AssetForm();
        model.AssetProductsList = RetrieveAssetProductsList();
        model.AssetStatusList = RetrieveAssetStatusList();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(AssetForm model)
    {
        var wd = model.WarrantyExpiryDate;

        if (ModelState.IsValid)
        {
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

        // Dropdown lists need to be repopulated again if validation fails
        model.AssetProductsList = RetrieveAssetProductsList();
        model.AssetStatusList = RetrieveAssetStatusList();
        model.WarrantyExpiryDate = wd;
        // Failed validation, return model
        return View(model);
    }


    /// <summary>
    /// Retrieves a list of available models from the underlying model service.
    /// </summary>
    /// <remarks>The returned list will never be null. If the model service fails to retrieve models, an empty
    /// list is returned instead.</remarks>
    /// <returns>A list of models if the retrieval operation succeeds; otherwise, an empty list.</returns>
    private List<AssetProduct>? RetrieveAssetProductsList()
    {
        var result = _modelService.GetAll();

        if (!result.Ok)
        {
            return new List<AssetProduct>();
        }

        return result.Data;
    }

    private List<AssetStatus>? RetrieveAssetStatusList()
    {
        var result = _assetStatusService.GetAllAssetStatuses();

        if (!result.Ok) return new List<AssetStatus>();

        return result.Data;
    }
}
