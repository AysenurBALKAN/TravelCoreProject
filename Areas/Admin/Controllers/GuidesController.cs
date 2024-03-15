using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TBusinessLayer.ValidationRules;
using TEntityLayer.Concrete;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class GuidesController : Controller
    {
        private readonly IGuideService _guideService;

        public GuidesController(IGuideService guideService)
        {
            _guideService = guideService;
        }
       
        public IActionResult Index()
        {
           var values= _guideService.TGetlist();
            return View(values);
        }

       
        [HttpGet]
        public IActionResult AddGuide()
        {
            
            return View();
        }
      
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }
       
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetById(id);
            return View(values);
        }

        
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

     
        public IActionResult ChangetoTrue(int id)
        {
            _guideService.TChangetoTrue(id);
            return RedirectToAction("Index","Guides",new {area="Admin" });
        }

       
        public IActionResult ChangetoFalse(int id)
        {
            _guideService.TChangetoFalse(id);
            return RedirectToAction("Index", "Guides", new { area = "Admin" });
        }
    }
}
