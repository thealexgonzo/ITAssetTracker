using ITAssetTracker.Infrastructure.Entities;

namespace ITAssetTracker.Application.Interfaces;

public interface ISupportTicketService
{
    List<SupportTicket> GetAll();
    SupportTicket GetById(int id);
    void Add(SupportTicket ticket);
    void Edit(SupportTicket ticket);
    void Delete(SupportTicket ticket);
}
