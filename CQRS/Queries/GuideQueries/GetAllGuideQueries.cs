using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Results.GetAllGuideQueryResult;

namespace TravelCoreProject.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQueries:IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
