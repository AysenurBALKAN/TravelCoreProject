using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Abstract;
using TEntityLayer.Concrete;
using TravelCoreProject.Areas.Admin.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetlist();
            List<AnnouncementListViewModel> model = new List< AnnouncementListViewModel>();
            foreach (var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.ID = item.AnnouncementId;
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;
                model.Add(announcementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
         public IActionResult AddAnnouncement()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(string p)
        {

            return View();
        }
    }
}
