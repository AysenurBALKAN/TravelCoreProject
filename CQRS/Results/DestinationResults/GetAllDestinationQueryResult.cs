using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capactiy { get; set; }
    }
}
