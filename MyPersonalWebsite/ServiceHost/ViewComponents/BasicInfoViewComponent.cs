using System.IO;
using _01_Query.Contract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BasicInfoViewComponent : ViewComponent
    {
        private readonly IBasicInfoQuery _basicInfoQuery;
        public BasicInfoViewComponent(IBasicInfoQuery basicInfoQuery)
        {
            _basicInfoQuery = basicInfoQuery;
        }

        public IViewComponentResult Invoke()
        {
            var basicInfo = _basicInfoQuery.GetBasicInformation();
            return View(basicInfo);
        }

      
    }
}
