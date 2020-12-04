using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var service = new List<Service>
            {
                new Service("طراح و دیزاین وب سایت",
                    "طراحی انواع سایت های شرکتی، فروشگاهی، خبری و ...  ",
                    1),
                new Service("برنامه نویسی وب سایت",
                    " برنامه نویسی انواع سایت های شرکتی، فروشگاهی، خبری و ... ",
                    2),
                new Service("مشاوره",
                    "مشاوره در زمینه های برنامه نویسی و کسب و کار های آنلاین",
                    3),
                new Service("سئو",
                    "انجام کلیه امورات مربوط به سئو و قرار گرفتن در رتیه یک گوگل",
                    4),
                new Service("تدریس",
                    "تدریس انواع زبان های برنامه نویسی",
                    5),
                new Service("تولید محتوا",
                    "انجام کلیه امورات مربوط به تولید محتوا در وب سایت و شبکه های اجتماعی",
                    6)
            };
            return View("_Service",service);
        }
    }
}
