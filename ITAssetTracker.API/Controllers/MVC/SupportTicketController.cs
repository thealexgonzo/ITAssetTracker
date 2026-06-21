using ITAssetTracker.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using ITAssetTracker.API.Models.SupportTicket;

namespace ITAssetTracker.API.Controllers.MVC;

public class SupportTicketController : Controller
{
    private readonly ISupportTicketService _supportTicketService;

    public SupportTicketController(ISupportTicketService supportTicketService)
    {
        _supportTicketService = supportTicketService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var tickets = _supportTicketService.ListAllAsync();
        SupportTicketList model = new();
        model.SupportTickets = tickets;
        return View(model);
    }
}
