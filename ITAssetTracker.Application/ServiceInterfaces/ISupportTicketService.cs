using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface ISupportTicketService
{
    List<SupportTicket> GetAll();
    SupportTicket GetById(int id);
    void Add(SupportTicket ticket);
    void Edit(SupportTicket ticket);
    void Delete(SupportTicket ticket);
}
