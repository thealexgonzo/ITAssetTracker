using ITAssetTracker.Domain.Entities;
namespace ITAssetTracker.Application.RepositoryInterfaces;

public interface ICategoryRepository
{
    List<Category> GetAll();
}
