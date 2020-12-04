using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class OveralSkillsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var skill = new List<OveralSkills>
            {
                new OveralSkills(1,"شبکه و نتورک",90),
                new OveralSkills(2,"وب سرور",90),
                new OveralSkills(3,"گیت و گیت هاب",95),
                new OveralSkills(4,"معماری تمیز",95),
                new OveralSkills(5,"لینوکس",80),
                new OveralSkills(6,"فتوشاپ",100),
                new OveralSkills(7,"کورل",75),
                new OveralSkills(8,"ایلوستریتور",70),
                new OveralSkills(9,"زبان انگلیسی",85),
                new OveralSkills(10,"زیان کوردی",100),
                new OveralSkills(11,"رابطه اجتماعی قوی",100),
                new OveralSkills(12,"انعطاف پذیری",85),
                new OveralSkills(13,"تایپ ده انگشتی",90),



            };
            return View("_OveralSkills", skill);
        }
    }
}
