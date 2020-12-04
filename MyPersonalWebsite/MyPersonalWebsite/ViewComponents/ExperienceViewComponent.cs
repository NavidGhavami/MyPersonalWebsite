using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            var exp = new List<Experience>
            {
                new Experience(1,
                    "از سال 1397 تا 1399",
                    "شرکت هواوی",
                    "در شرکت هواوی بر روی پروژه CRM و CBS به عنوان برنامه نویس مشغول به کار بودم. "),
                new Experience(2,
                    "از سال 1394 تا 1395",
                    "شرکت تحلیل داده",
                    "در شرکت تحلیل داده به عنوان برنامه نویس دسکتاپ فعالیت داشته ام.  "),
                new Experience(3,
                    "از سال 1397 تا 1399",
                    "آموزشگاه فنی و حرفه ای کاردو",
                    "در این آموزشگاه مدرس و مشاور در زمینه های برنامه نویسی، طراحی و ... بودم.")
            };
            return View("_Experience", exp);
        }
    }
}
