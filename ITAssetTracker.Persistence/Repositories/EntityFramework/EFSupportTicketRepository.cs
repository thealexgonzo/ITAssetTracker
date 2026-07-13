using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Persistence.Repositories.EntityFramework
{
    public class EFSupportTicketRepository : BaseRepository<SupportTicket>, ISupportTicketRepository
    {
        public EFSupportTicketRepository(ITAssetTrackerContext dbContext): base(dbContext)
        {  
        }
    }
}
