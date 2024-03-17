using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TEntityLayer.Concrete;
using TravelCoreProject.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetlist());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination p)
        {
            p.status = true;
            _destinationService.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

 
        public IActionResult GetById(int DestinationId)
        {
          var values=  _destinationService.TGetById(DestinationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
          
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
           
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
        //public static List<CityClass> Cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityId=1,
        //        CityName="Sarajeva",
        //        CityCountry="Bosna-Hersek"
        //    }

        //};


    }
}
