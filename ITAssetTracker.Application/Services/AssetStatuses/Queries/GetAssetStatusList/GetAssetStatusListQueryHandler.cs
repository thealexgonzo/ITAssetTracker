using AutoMapper;
using ITAssetTracker.Application.Contracts.Repositories;
using ITAssetTracker.Domain.Entities;
using MediatR;

namespace ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusList;

public class GetAssetStatusListQueryHandler: IRequestHandler<GetAssetStatusListQuery, List<AssetStatusListViewModel>>
{
    private readonly IMapper mapper;
    private readonly IAssetStatusRepository assetStatusRepository;

    public GetAssetStatusListQueryHandler(IMapper mapper, IAssetStatusRepository assetStatusRepository)
    {
        this.mapper = mapper;
        this.assetStatusRepository = assetStatusRepository;
    }
    public async Task<List<AssetStatusListViewModel>> Handle(GetAssetStatusListQuery request, CancellationToken cancellationToken)
    {
        List<AssetStatus> allAssetStatuses = (await assetStatusRepository.ListAllAsync()).ToList();
        return mapper.Map<List<AssetStatusListViewModel>>(allAssetStatuses);
    }
}


