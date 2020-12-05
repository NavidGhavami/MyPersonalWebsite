using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var project = new List<Projects>
            {
                new Projects(1,"Antomi","فروشگاهی","antomi.png"),
                new Projects(2,"Blogxer","خبری","blogxer.png"),
            };
            return View("_Project", project);
        }
    }
}
