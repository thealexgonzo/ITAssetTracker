using ITAssetTracker.Application.Services.Assets.Commands.CreateAsset;
using ITAssetTracker.Application.Services.Assets.Commands.DeleteAsset;
using ITAssetTracker.Application.Services.Assets.Commands.UpdateAsset;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetDetails;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsExport;
using ITAssetTracker.Application.Services.Assets.Queries.GetAssetsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssetController : Controller
{
    private readonly IMediator mediator;

    public AssetController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet("{id}", Name = "GetAssetById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<AssetDetailsViewModel>> GetAssetById(int id)
    {
        GetAssetDetailsQuery getAssetDetailsQuery = new() { Id = id };
        AssetDetailsViewModel assetDetails = await mediator.Send(getAssetDetailsQuery);
        return Ok(assetDetails);
    }

    [HttpGet("all", Name = "GetAllAssets")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<AssetListViewModel>>> GetAllAssets()
    {
        List<AssetListViewModel> allAssets = await mediator.Send(new GetAssetsListQuery());
        return Ok(allAssets);
    }

    [HttpPost(Name = "AddAsset")]
    public async Task<ActionResult<int>> Create([FromBody] CreateAssetCommand createAssetCommand)
    {
        int response = await mediator.Send(createAssetCommand);
        return Ok(response);
    }

    [HttpPut(Name = "UpdateAsset")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateAsset([FromBody] UpdateAssetCommand updateAssetCommand)
    {
        await mediator.Send(updateAssetCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteAsset")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteAsset(int id)
    {
        DeleteAssetCommand deleteAssetCommand = new DeleteAssetCommand() { Id = id };
        await mediator.Send(deleteAssetCommand);
        return NoContent();
    }

    [HttpGet("export", Name = "ExportAssets")]
    public async Task<ActionResult> ExportAssets()
    {
        AssetExportFileViewModel fileDto = await mediator.Send(new GetAssetsExportQuery());

        return File(fileDto.Data, fileDto.ContentType, fileDto.AssetExportFileName);
    }
}