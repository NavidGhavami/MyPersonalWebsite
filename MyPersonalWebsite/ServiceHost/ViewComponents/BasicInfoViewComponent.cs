using _01_Query.Contract.BasicInfo;
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
