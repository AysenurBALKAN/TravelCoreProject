using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TDataAccesLayer.Concrete;
using TravelCoreProject.CQRS.Queries.GuideQueries;
using TravelCoreProject.CQRS.Results.GetAllGuideQueryResult;

namespace TravelCoreProject.CQRS.Handlers.GuideHandlers
{
    public class GetByIdGuideQueryHandler: IRequestHandler<GetByIdGuideQuery, GetByIdGuideQueryResult>
    {
        private readonly Context _context;

        public GetByIdGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetByIdGuideQueryResult> Handle(GetByIdGuideQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.id);
            return new GetByIdGuideQueryResult
            {
                GuideId = values.GuideId,
                GuideName = values.GuideName,
                Description = values.Description
            };
        }

    }
}
