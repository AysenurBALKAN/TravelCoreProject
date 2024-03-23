using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCoreProject.CQRS.Commands;
using TravelCoreProject.CQRS.Queries.GuideQueries;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [AllowAnonymous]
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQueries());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetByIdGuideQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuides()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuides( CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

    }
}
