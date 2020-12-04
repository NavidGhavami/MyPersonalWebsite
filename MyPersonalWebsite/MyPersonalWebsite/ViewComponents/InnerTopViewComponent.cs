using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class InnerTopViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var innerTop =

                new InnerTop(ownerName: "نوید قوامی",
                    ownerDescription: "برنامه نویس و طراح وب سایت می باشم. " +
                                                                        "از سال 97 فعالیت خود را در حوزه برنامه نویسی  به صورت جدی شروع کرده ام " +
                                                                        "و مسئولیت های تخصصی توسعه پروژه، مشاوره، تدریس و ... را به عهده گرفته ام.",
                    ownerDescription2: "اینجانب رمز موفقیت در کار را تلاش بی وقفه و مستمر همراه با داشتن انگیزه سرلوحه خود قرار داده ام.");



            return View("_InnerTop", innerTop);
        }

    }
}
