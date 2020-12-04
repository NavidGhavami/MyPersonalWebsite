using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var edu = new List<Education>
            {
                new Education(1,
                    "از سال 1396 تا 1398",
                    "دانشگاه خاتم تهران | کارشناسی ارشد",
                    "مقطع کارشناسی ارشد را در رشته مهندسی کامپیوتر، گرایش نرم افزار با معدل 16/73 و عنوان پایان نامه در زمینه یادگیری عمیق با موفقیت به پایان رسانیدم. "),
                new Education(2,
                    "از سال 1391 تا 1395",
                    "دانشگاه کردستان | کارشناسی ",
                    "مقطع کارشناسی را در رشته مهندسی کامپیوتر، گرایش نرم افزار با معدل 17/48 با موفقیت به پایان رسانیدم.  "),
                new Education(3,
                    "از سال 1390 تا 1391",
                    " فارابی  | پیش دانشگاهی ",
                    "مقطع پیش دانشگاهی را با معدل 17/81 و در رشته ریاضی و فیزیک با موفقیت به پایان رسانیدم.")
            };
            return View("_Education",edu);
        }
    }
}
