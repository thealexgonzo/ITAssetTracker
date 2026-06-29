using AutoMapper;
using ITAssetTracker.Application.Contracts.Persistence;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.Categories.Queries.GetCategoriesList
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<CategoryListViewModel>>
    {
        private readonly IAsyncRepository<Category> categoryRepository;
        private readonly IMapper mapper;

        public GetCategoryListQueryHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task<List<CategoryListViewModel>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            List<Category> categories = (await categoryRepository.ListAllAsync()).ToList();
            return mapper.Map<List<CategoryListViewModel>>(categories);
        }
    }
}
