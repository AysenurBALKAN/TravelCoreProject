using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Commands;
using TravelCoreProject.CQRS.Handlers.DestinationHandlers;
using TravelCoreProject.CQRS.Queries.DestiantionQueries;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        
        private readonly GetAllDestinationHandler _getAllDestinationHandler;
        private readonly GetDestinationByIdHandle _getDestinationByIdHandle;
        private readonly CreateDestiantionCommandHandler _createDestiantionCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandle _updateDestinationCommandHandle;

        public DestinationCQRSController(GetAllDestinationHandler getAllDestinationHandler, GetDestinationByIdHandle getDestinationByIdHandle = null, CreateDestiantionCommandHandler createDestiantionCommandHandler = null, RemoveDestinationCommandHandler removeDestinationCommandHandler = null, UpdateDestinationCommandHandle updateDestinationCommandHandle = null)
        {
            _getAllDestinationHandler = getAllDestinationHandler;
            _getDestinationByIdHandle = getDestinationByIdHandle;
            _createDestiantionCommandHandler = createDestiantionCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandle = updateDestinationCommandHandle;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIdHandle.Handle(new GetDestinationByIdQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestiantionCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandle.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
