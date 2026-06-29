using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Application.Services.Assignments.Queries.GetAssignmentsList
{
    public class GetAssignmentListQuery: IRequest<List<AssignmentListViewModel>>
    {
    }
}
