using ITAssetTracker.Domain.Entities;

namespace ITAssetTracker.Application.ServiceInterfaces;

public interface ICategoryService
{
    Result<List<Category>> GetAll();
}
