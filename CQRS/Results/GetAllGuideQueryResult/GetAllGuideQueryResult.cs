using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.CQRS.Results.GetAllGuideQueryResult
{
    public class GetAllGuideQueryResult
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
    }
}
