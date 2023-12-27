using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBusinessLayer.Concrete;
using TDataAccesLayer.EntityFramework;

namespace TravelCoreProject.ViewComponents
{
    public class _Feature:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featuremanager.TGetlist();
           
            return View();
        }
    }
}
