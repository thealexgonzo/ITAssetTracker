using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly IMediator mediator;

    public CategoryController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
