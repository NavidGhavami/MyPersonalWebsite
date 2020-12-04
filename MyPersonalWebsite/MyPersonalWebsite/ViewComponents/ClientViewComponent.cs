using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ClientViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var client = new List<Client>
            {
                new Client(1,"لوازم خانگی محمدی","logo1.png"),
                new Client(2,"خبرگزاری دلوین","logo2.png"),
                new Client(3,"فروشگاه بانه کالا","logo3.png"),
                new Client(4,"فروشگاه آنلاین هنری ژیوار","logo4.png"),
            };
            return View("_Client", client);
        }
    }
}
