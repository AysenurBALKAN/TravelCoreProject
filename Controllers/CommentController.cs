using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Concrete;
using TDataAccesLayer.EntityFramework;
using TEntityLayer.Concrete;

namespace TravelCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfComment());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            p.DestinationId = 3;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
