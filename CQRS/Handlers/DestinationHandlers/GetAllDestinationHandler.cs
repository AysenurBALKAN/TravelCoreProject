using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDataAccesLayer.Concrete;
using TravelCoreProject.CQRS.Queries.DestiantionQueries;
using TravelCoreProject.CQRS.Results.DestinationResults;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationHandler
    {
        private readonly Context _context;

        public GetAllDestinationHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.DestinationId,
                City=x.City,
                Capactiy = x.Capacity,
                DayNight = x.DayNight,
                Price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
