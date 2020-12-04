using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyPersonalWebsite.ViewComponents
{
    public class AbilityViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var ability = new List<Models.Ability>
            {
                new Models.Ability(1,"برنامه نویسی حرفه ای"),
                new Models.Ability(2,"مدیریت"),
                new Models.Ability(3,"انعطاف پذیری"),
                new Models.Ability(4,"همکاری"),
                new Models.Ability(5,"تحویل فوری"),
                new Models.Ability(6,"خلق ایده"),
                new Models.Ability(7,"گرافیک اختصاصی"),
                new Models.Ability(8,"جدیدترین تکنولوژی"),
                new Models.Ability(9,"آموزش اختصاصی"),
            };
            return View("_Ability", ability);
        }
    }
}
