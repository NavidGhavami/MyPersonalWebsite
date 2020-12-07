using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Models;

namespace MyPersonalWebsite.ViewComponents
{
    public class ArticleDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var detail = ArticleStore.GetArticles();
            return View("ArticlesDetail", detail);
        }
    }
}
