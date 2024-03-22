using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.CQRS.Commands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
