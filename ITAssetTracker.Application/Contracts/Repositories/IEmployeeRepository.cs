using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.Contracts.Repositories;

public interface IEmployeeRepository: IAsyncRepository<Employee>
{
}
