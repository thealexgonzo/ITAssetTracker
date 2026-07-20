using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ManufacturerController : Controller
{
    private readonly IMediator mediator;

    public ManufacturerController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
