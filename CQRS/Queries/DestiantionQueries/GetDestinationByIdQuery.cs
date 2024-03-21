using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.CQRS.Queries.DestiantionQueries
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
      
    }
}
