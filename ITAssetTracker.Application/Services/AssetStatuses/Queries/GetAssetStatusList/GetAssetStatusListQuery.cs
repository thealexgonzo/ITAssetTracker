using MediatR;

namespace ITAssetTracker.Application.Services.AssetStatuses.Queries.GetAssetStatusList;

public class GetAssetStatusListQuery : IRequest<List<AssetStatusListViewModel>>
{
}
