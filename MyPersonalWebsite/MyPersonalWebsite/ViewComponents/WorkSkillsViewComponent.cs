using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class WorkSkillsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var skill = new List<WorkSkills>
            {
                new WorkSkills(1,"C#",90),
                new WorkSkills(2,"ASP.NET MVC",90),
                new WorkSkills(3,"ASP.NET Core",90),
                new WorkSkills(4,"WINDOWS FORMS",95),
                new WorkSkills(5,"ANGULAR",70),
                new WorkSkills(6,"IONIC",80),
                new WorkSkills(7,"HTML 5",100),
                new WorkSkills(8,"CSS 3",90),
                new WorkSkills(9,"JAVA SCRIPT",85),
                new WorkSkills(10,"BOOTSTRAP",90),
                new WorkSkills(10,"JQUERY",70),
                new WorkSkills(10,"PYTHON",85),
                new WorkSkills(10,"MACHINE LEARNING",75),
                new WorkSkills(10,"DEEP LEARNING",80),
                new WorkSkills(10,"MATHLAB",65),


            };
            return View("_WorkSkills", skill);
        }
    }
}
