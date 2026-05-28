using ITAssetTracker.Application.RepositoryInterfaces;
using ITAssetTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ITAssetTracker.Infrastructure.Repositories.EntityFramework;

public class EFAssetHistoryRepository : IAssetHistoryRepository
{
    private ITAssetTrackerContext _dbContext;
    public EFAssetHistoryRepository(ITAssetTrackerContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<AssetHistory> GetAllAssetHistory(Guid id)
    {
        //return _dbContext.AssetHistories
        //    .Where(a => a.AssetId == id).OrderByDescending(a => a.UpdatedDate).Include(User);
        return _dbContext.AssetHistories
            .Include(u => u.CreatedByUser)
            .Include(u => u.UpdatedByUser)
            .Where(a => a.AssetId == id).OrderByDescending(u => u.UpdatedDate).ToList();

        //var query = from assetHistory  in _dbContext.Set<AssetHistory>()
        //            join user in _dbContext.Set<User>()
        //                on assetHistory.CreatedByUser equals user.UserId
        //            join employee in _dbContext.Set<Employee>()
        //                on user.UserId equals employee.EmployeeId
        //            select new { assetHistory, user, employee };
    }
}
