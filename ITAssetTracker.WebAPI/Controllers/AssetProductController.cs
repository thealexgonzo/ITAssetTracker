using ITAssetTracker.Application.Services.AssetProducts.Commands.CreateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Commands.DeleteAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Commands.UpdateAssetProduct;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductDetails;
using ITAssetTracker.Application.Services.AssetProducts.Queries.GetAssetProductList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssetProductController : Controller
{
    private readonly IMediator mediator;

    public AssetProductController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet("{id}", Name = "GetAssetProductById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<AssetProductDetailsViewModel>> GetAssetAssignmentById(int id)
    {
        GetAssetProductDetailsQuery getAssetProductDetailsQuery = new() { Id = id };
        AssetProductDetailsViewModel assetProductDetailsViewModel = await mediator.Send(getAssetProductDetailsQuery);
        return Ok(assetProductDetailsViewModel);
    }

    [HttpGet("all", Name = "GetAllAssetProducts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<AssetProductListViewModel>>> GetAllAssetAssignments()
    {
        List<AssetProductListViewModel> allAssetProducts = await mediator.Send(new GetAssetProductListQuery());
        return Ok(allAssetProducts);
    }

    [HttpPost(Name = "AddAssetProduct")]
    public async Task<ActionResult<int>> AddAssetProduct([FromBody] CreateAssetProductCommand createAssetProductCommand)
    {
        int respsone = await mediator.Send(createAssetProductCommand);
        return respsone;
    }

    [HttpPut(Name = "UpdateAssetProduct")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateAssetProduct([FromBody] UpdateAssetProductCommand updateAssetProductCommand)
    {
        await mediator.Send(updateAssetProductCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteAssetProduct")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteAssetProduct(int id)
    {
        DeleteAssetProductCommand deleteAssetProductCommand = new DeleteAssetProductCommand() { Id = id };
        await mediator.Send(deleteAssetProductCommand);
        return NoContent();
    }
}
