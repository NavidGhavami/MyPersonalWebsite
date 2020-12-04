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
                    ownerDescription: "برنامه نویس و علاقه مند به برنامه نویسی می باشم. " +
                                                                        "از سال 97 فعالیت خود را در حوزه برنامه نویسی، به ویژه برنامه نویسی وب سایت و موبایل  به صورت جدی شروع کرده ام " +
                                                                        "و مسئولیت های تخصصی توسعه پروژه، مشاوره، تدریس و ... را به عهده گرفته ام.",
                    ownerDescription2: "اینجانب رمز موفقیت در کار را تلاش بی وقفه در کار و مطالعه مستمر همراه با داشتن انگیزه سرلوحه خود قرار داده ام.");



            return View("_InnerTop", innerTop);
        }

    }
}
