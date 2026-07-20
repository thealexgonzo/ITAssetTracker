using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AssetTypeController : Controller
{
    private readonly IMediator mediator;

    public AssetTypeController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
