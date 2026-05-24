using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface ISupportTicketRepository
{
    List<SupportTicket> GetAll();
    SupportTicket GetById(int id);
    void Add(SupportTicket ticket);
    void Edit(SupportTicket ticket);
    void Delete(SupportTicket ticket);
}
