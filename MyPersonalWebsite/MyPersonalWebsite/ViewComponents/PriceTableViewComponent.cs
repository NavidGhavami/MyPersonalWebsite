using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class PriceTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var price = new List<PriceTable>
            {
                new PriceTable("وب سایت شرکتی",
                    "12",
                    "در این پلن وب سایت شرکتی مورد نظر به صورت کاملا حرفه ای طراحی و برنامه نویسی می شود." +
                    "   از جمله ویژگی های این پلن می توان به مواردی از قبیل ارتباط با سامانه ایمیلی و ارتباط با بانک اطلاعاتی، پنل مدیریتی کاملا حرفه ای و شخصی سازی شده" +
                    "، پشتیبانی 3 ماهه رایگان و آموزش حضوری اختصاصی اشاره کرد.",
                    1),
                new PriceTable("وب سایت فروشگاهی",
                    "18",
                    "در این پلن وب سایت شرکتی مورد نظر به صورت کاملا حرفه ای طراحی و برنامه نویسی می شود." +
                    "   کلیه ویژگی های سایت شرکتی را دارا می باشد و همچنین درگاه بانکی اختصاصی برای فروشگاه آنلاین پیاده سازی می شود." +
                    " پشتیبانی این پلن 6 ماهه و به صورت رایگان می باشد " +
                    "این دوره به صورت حضوری،  کامل و جامع آموزش داده می شود.  ",
                    2)
            };
            return View("_PriceTable", price);
        }
    }
}
