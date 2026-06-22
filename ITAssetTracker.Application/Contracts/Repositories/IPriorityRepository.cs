using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Contracts.Repositories;

public interface IPriorityRepository: IAsyncRepository<Priority>
{
}
