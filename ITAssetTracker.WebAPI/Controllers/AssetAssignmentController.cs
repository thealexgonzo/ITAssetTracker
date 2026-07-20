using ITAssetTracker.Application.Services.Assignments.Commands.CreateAssignment;
using ITAssetTracker.Application.Services.Assignments.Commands.DeleteAssignment;
using ITAssetTracker.Application.Services.Assignments.Commands.UpdateAssignment;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssetAssignmentsExport;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails;
using ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITAssetTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssetAssignmentController : Controller
{
    private readonly IMediator mediator;

    public AssetAssignmentController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet("{id}", Name = "GetAssetAssignmentById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<AssignmentDetailsViewModel>> GetAssetAssignmentById(int id)
    {
        GetAssignmentDetailsQuery getAssignmentDetailsQuery = new() { Id = id };
        AssignmentDetailsViewModel assignmentDetailsViewModel = await mediator.Send(getAssignmentDetailsQuery);
        return Ok(assignmentDetailsViewModel);
    }

    [HttpGet("all", Name = "GetAllAssetAssignments")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<AssignmentListViewModel>>> GetAllAssetAssignments()
    {
        List<AssignmentListViewModel> allAssetAssignments = await mediator.Send(new GetAssignmentListQuery());
        return Ok(allAssetAssignments);
    }

    [HttpPost(Name = "AddAssetAssignment")]
    public async Task<ActionResult<int>> AddAssetAssignment([FromBody] CreateAssignmentCommand createAssetAssignmentCommand)
    {
        int respsone = await mediator.Send(createAssetAssignmentCommand);
        return respsone;
    }

    [HttpPut(Name = "UpdateAssetAssignment")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> UpdateAssetAssignment([FromBody] UpdateAssignmentCommand updateAssetAssignmentCommand)
    {
        await mediator.Send(updateAssetAssignmentCommand);
        return NoContent();
    }

    [HttpDelete("{id}", Name = "DeleteAssetAssignment")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> DeleteAssetAssignment(int id)
    {
        DeleteAssignmentCommand deleteAssetAssignmentCommand = new DeleteAssignmentCommand() { Id = id };
        await mediator.Send(deleteAssetAssignmentCommand);
        return NoContent();
    }

    [HttpGet("export", Name = "ExportAssetAssignments")]
    public async Task<ActionResult> ExportAssetAssignments()
    {
        AssetAssignmentsExportFileViewModel fileDto = await mediator.Send(new GetAssetAssignmentsExportQuery());

        return File(fileDto.Data, fileDto.ContentType, fileDto.AssetAssignmentsExportFileName);
    }
}
