using ITAssetTracker.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ITAssetTracker.MVC.Models.SupportTicket;

namespace ITAssetTracker.MVC.Controllers.MVC;

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
        var tickets = _supportTicketService.GetAll();
        SupportTicketList model = new();
        model.SupportTickets = tickets;
        return View(model);
    }
}
