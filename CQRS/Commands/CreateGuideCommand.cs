using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.CQRS.Commands
{
    public class CreateGuideCommand:IRequest
    {
        public string GuideName { get; set; }
        public string Description { get; set; }

       
        public bool Status { get; set; }
    }
}
