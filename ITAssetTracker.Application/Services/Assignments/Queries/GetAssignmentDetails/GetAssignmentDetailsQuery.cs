using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails;

public class GetAssignmentDetailsQuery: IRequest<AssignmentDetailsViewModel>
{
    public int Id { get; set; }
}
