using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDataAccesLayer.Concrete;
using TravelCoreProject.CQRS.Commands;

namespace TravelCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandle
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandle(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }

}
