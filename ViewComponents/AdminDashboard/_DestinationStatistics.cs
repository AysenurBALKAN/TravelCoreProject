﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProject.ViewComponents.AdminDashboard
{
    public class _DestinationStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
