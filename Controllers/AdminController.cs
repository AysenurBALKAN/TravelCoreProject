using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        } 
        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }
    }
}
