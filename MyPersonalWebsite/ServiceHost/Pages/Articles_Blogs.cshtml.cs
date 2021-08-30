using System.Collections.Generic;
using _01_Query.Contract.Article;
using _01_Query.Contract.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class Articles_BlogsModel : PageModel
    {
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public List<ArticleCategoryQueryModel> ArticleCategories;


        public Articles_BlogsModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _articleCategoryQuery = articleCategoryQuery;
        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();

        }

    }
}
