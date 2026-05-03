using ITAssetTracker.Application.Interfaces;
using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Application.Services;

public class SupportTicketService : ISupportTicketService
{
    private ISupportTicketRepository _supportTicketService;

    public SupportTicketService(ISupportTicketRepository supportTicketService)
    {
        _supportTicketService = supportTicketService;
    }

    public void Add(SupportTicket ticket)
    {
        throw new NotImplementedException();
    }

    public void Delete(SupportTicket ticket)
    {
        throw new NotImplementedException();
    }

    public void Edit(SupportTicket ticket)
    {
        throw new NotImplementedException();
    }

    public List<SupportTicket> GetAll()
    {
        try
        {
            return _supportTicketService.GetAll();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public SupportTicket GetById(int id)
    {
        throw new NotImplementedException();
    }
}
