using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TBusinessLayer.Concrete;
using TDataAccesLayer.EntityFramework;
using TEntityLayer.Concrete;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        
public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _destinationService.TGetlist();
            return View(values);
        } 
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
