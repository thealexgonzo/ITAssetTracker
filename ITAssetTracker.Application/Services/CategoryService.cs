using ITAssetTracker.Application.ServiceInterfaces;
using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Application.RepositoryInterfaces;

namespace ITAssetTracker.Application.Services;

public class CategoryService : ICategoryService
{
    ICategoryRepository _categoryService;

    public CategoryService(ICategoryRepository categoryService)
    {
        _categoryService = categoryService;
    }

    public Result<List<Category>> GetAll()
    {
        try
        {
            return ResultFactory.Success<List<Category>>(_categoryService.GetAll());
        }
        catch (Exception ex)
        {
            return ResultFactory.Fail<List<Category>>(ex.Message);
        }
    }
}
