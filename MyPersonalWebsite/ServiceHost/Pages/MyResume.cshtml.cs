using System.IO;
using _01_Query.Contract;
using _01_Query.Contract.BasicInfo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class MyResumeModel : PageModel
    {
        private readonly IBasicInfoQuery _basicInfoQuery;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MyResumeModel(IBasicInfoQuery basicInfoQuery, IWebHostEnvironment webHostEnvironment)
        {
            _basicInfoQuery = basicInfoQuery;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnGet()
        {
        }

        public FileResult OnGetDownloadPersianResume()
        {
            var persianResume = _basicInfoQuery.PersianResume();
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, persianResume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", persianResume);
        }
        public FileResult OnGetDownloadEnglishResume()
        {
            var englishResume = _basicInfoQuery.EnglishResume();
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, englishResume);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", englishResume);
        }
        public FileResult OnGetDownloadRecommendationLetter()
        {
            var recommendationLetter = _basicInfoQuery.RecommendationLetter();
            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Pictures");
            string FileNameWithPath = Path.Combine(FilePath, recommendationLetter);
            byte[] bytes = System.IO.File.ReadAllBytes(FileNameWithPath);
            return File(bytes, "application/octet-stream", recommendationLetter);
        }
    }
}
