using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : Controller
{
    private readonly IMediator mediator;

    public DepartmentController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
