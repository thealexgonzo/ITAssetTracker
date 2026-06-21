using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Application.RepositoryInterfaces;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework
{
    public class EFSupportTicketRepository : ISupportTicketRepository
    {
        private ITAssetTrackerContext _dbContext;

        public EFSupportTicketRepository(ITAssetTrackerContext dbContext)
        {
            _dbContext = dbContext;    
        }

        public void AddAsync(SupportTicket ticket)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(SupportTicket ticket)
        {
            throw new NotImplementedException();
        }

        public void Edit(SupportTicket ticket)
        {
            throw new NotImplementedException();
        }

        public List<SupportTicket> ListAllAsync()
        {
            return _dbContext.SupportTickets.ToList();
        }

        public SupportTicket GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
