using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : Controller
{
    private readonly IMediator mediator;

    public EmployeeController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }
}
