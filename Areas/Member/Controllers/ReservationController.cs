using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Concrete;
using TDataAccesLayer.EntityFramework;
using TEntityLayer.Concrete;

namespace TravelCoreProject.Areas.Member.Controllers
{
    [Area("Member")]

   
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _usermanager;

        public ReservationController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task< IActionResult> MyCurrentResevation()
        {
            var values = _usermanager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByWaitApproval(values.Id);

            return View(valuesList);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = _usermanager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByWaitApproval(values.Id);

            return View(valuesList);
        }

        [HttpGet]
        public async  Task<IActionResult> MyApprovalReservation()
        {
            var values = _usermanager.FindByNameAsync(User.Identity.Name);
           var valuesList= reservationManager.GetListWithReservationByWaitApproval(values.Id);

            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetlist()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            reservationManager.TAdd(p);

            return RedirectToAction("MyCurrentResrvation");
         
        }

        
    }
}
