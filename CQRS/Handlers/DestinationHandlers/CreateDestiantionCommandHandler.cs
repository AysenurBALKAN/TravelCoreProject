using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDataAccesLayer.Concrete;
using TEntityLayer.Concrete;
using TravelCoreProject.CQRS.Commands;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestiantionCommandHandler
    {
        private readonly Context _context;

        public CreateDestiantionCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add( new Destination { 
                City=command.City,
                Price=command.Price,
                DayNight=command.DayNight,
                Capacity=command.Capacity,
                status=true
            });
            _context.SaveChanges();
        }
    }
}
