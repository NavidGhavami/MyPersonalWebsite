using System.Collections.Generic;
using _0_Framework.Domain;
using BlogManegement.Application.Contract.Article;

namespace BlogManagement.Domain.Article
{
    public interface IArticleRepository : IRepository<long, Article>
    {
        EditArticle GetDetails(long id);
        List<ArticleViewModel> Search(ArticleSearchModel searchModel);
        Article GetWithCategory(long id);
    }
}
