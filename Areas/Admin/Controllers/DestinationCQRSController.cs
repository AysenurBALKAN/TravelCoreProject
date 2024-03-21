using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Handlers.DestinationHandlers;
using TravelCoreProject.CQRS.Queries.DestiantionQueries;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        
        private readonly GetAllDestinationHandler _getAllDestinationHandler;
        private readonly GetDestinationByIdHandle _getDestinationByIdHandle;

        public DestinationCQRSController(GetAllDestinationHandler getAllDestinationHandler, GetDestinationByIdHandle getDestinationByIdHandle)
        {
            _getAllDestinationHandler = getAllDestinationHandler;
            _getDestinationByIdHandle = getDestinationByIdHandle;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationHandler.Handle();
            return View(values);
        }

        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdHandle.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }
    }
}
