using MediatR;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentDetails;

public class GetAssignmentDetailsQuery: IRequest<AssignmentDetailsViewModel>
{
    public Guid Id { get; set; }
}
