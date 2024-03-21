using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDataAccesLayer.Concrete;
using TravelCoreProject.CQRS.Queries.DestiantionQueries;
using TravelCoreProject.CQRS.Results.DestinationResults;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdHandle
    {
        private readonly Context _context;

        public GetDestinationByIdHandle(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdResult
            {
                Id = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight
            };
        }
    }
}
