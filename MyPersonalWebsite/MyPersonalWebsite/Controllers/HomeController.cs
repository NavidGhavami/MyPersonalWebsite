using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;
using System.Diagnostics;
using System.Net.Mime;
using System.Threading;

namespace MyPersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult ExperienceAndSkills()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Articles()
        {
            return View();
        }
        public IActionResult ArticlesDetail()
        {
            //var detail = new Articles()
            //{

            //};
            return View();
        }
        public IActionResult ContactMe()
        {
            return View();
        }

        public FileResult Resume()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/images/CVFile/Resume.jpg");
            const string filename = "NavidGhavami_Resume.jpg";
            return File(filebyte, MediaTypeNames.Image.Jpeg, filename);
        }
        public FileResult RecommandationLetter()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/images/CVFile/Letter.jpg");
            const string filename = "NavidGhavami_RecommandationLetter.jpg";
            return File(filebyte, MediaTypeNames.Image.Jpeg, filename);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}