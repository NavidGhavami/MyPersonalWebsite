using System.Collections.Generic;
using _0_Framework.Domain;
using BlogManegement.Application.Contract.ArticleCategory;

namespace BlogManagement.Domain.ArticleCategory
{
    public interface IArticleCategoryRepository : IRepository<long , ArticleCategory>
    {
        List<ArticleCategoryViewModel> Search(ArticleCategorySearchModel searchModel);
        EditArticleCategory GetDetails(long id);
        string GetSlugBy(long id);
        List<ArticleCategoryViewModel> GetArticleCategories();
    }
}
