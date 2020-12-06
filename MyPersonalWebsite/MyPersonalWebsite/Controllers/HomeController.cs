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

        [HttpPost]
        public IActionResult ContactMe(ContactMe.ContactForm contact)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. لطفا دوباره تلاش کنید.";
                return View(contact);
            }

            ViewBag.success = "پیغام شما با موفقیت ارسال شد. با تشکر از شما.";
            ModelState.Clear();
            return View();
        }

        public FileResult Resume()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/images/CVFile/Resume.jpg");
            const string filename = "Navid.Ghavami_Resume.jpg";
            return File(filebyte, MediaTypeNames.Image.Jpeg, filename);
        }
        public FileResult RecommendationLetter()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/images/CVFile/Letter.jpg");
            const string filename = "Navid.Ghavami_Recommandation Letter.jpg";
            return File(filebyte, MediaTypeNames.Image.Jpeg, filename);
        }

      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}