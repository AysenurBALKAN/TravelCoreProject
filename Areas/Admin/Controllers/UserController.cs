using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TEntityLayer.Concrete;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservatonService _reservatonService;
        public UserController(IAppUserService appUserService,IReservatonService reservatonService)
        {
            _appUserService = appUserService;
            _reservatonService = reservatonService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetlist();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {

            var values = _appUserService.TGetById(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {

            var values = _appUserService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {

            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {

            _appUserService.TGetlist();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values = _reservatonService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
