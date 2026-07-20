using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ResolutionController : Controller
{
    private readonly IMediator mediator;

    public ResolutionController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
