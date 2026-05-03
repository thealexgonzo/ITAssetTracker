using ITAssetTracker.Infrastructure.Entities;
using ITAssetTracker.Infrastructure.Interfaces;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework
{
    public class EFSupportTicketRepository : ISupportTicketRepository
    {
        private ITAssetTrackerContext _dbContext;

        public EFSupportTicketRepository(ITAssetTrackerContext dbContext)
        {
            _dbContext = dbContext;    
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
            return _dbContext.SupportTickets.ToList();
        }

        public SupportTicket GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
