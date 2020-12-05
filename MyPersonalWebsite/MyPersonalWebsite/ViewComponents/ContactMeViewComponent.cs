using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ContactMeViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var contact = new ContactMe(
                1,
                "ایران . تهران . میدان ونک . خیابان ونک . پلاک 12",
                "navid_ghavami@outlook.com",
                "8585 787 0933",
                "شنبه تا پنج شنبه ساعت 8 الی 21");


            return View("_ContactMe", contact);
        }
    }
}
