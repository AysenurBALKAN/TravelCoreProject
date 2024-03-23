using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Results.GetAllGuideQueryResult;

namespace TravelCoreProject.CQRS.Queries.GuideQueries
{
    public class GetByIdGuideQuery:IRequest<GetByIdGuideQueryResult>
    {
        public GetByIdGuideQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
