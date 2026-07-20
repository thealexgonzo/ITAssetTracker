using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupportTicketController : Controller
{
    private readonly IMediator mediator;

    public SupportTicketController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    public IActionResult Index()
    {
        return View();
    }
}
