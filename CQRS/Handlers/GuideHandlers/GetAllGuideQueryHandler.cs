using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQueries,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQueries request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                Description=x.Description,
                image=x.image,
                GuideName=x.GuideName
            }).AsNoTracking().ToListAsync();
        }
    }
}
