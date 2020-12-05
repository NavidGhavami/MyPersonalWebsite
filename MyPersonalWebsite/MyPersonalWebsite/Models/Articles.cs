using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models
{
    public class Articles
    {
        public long ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleCategory { get; set; }
        public string CreateDate { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleImage { get; set; }

        public Articles(long articleId, string articleTitle, string articleCategory, string createDate, string articleDescription, string articleImage)
        {
            ArticleID = articleId;
            ArticleTitle = articleTitle;
            ArticleCategory = articleCategory;
            CreateDate = createDate;
            ArticleDescription = articleDescription;
            ArticleImage = articleImage;

        }

    }

    public class ArticleDetail
    {
        public long ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleCategory { get; set; }
        public string CreateDate { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleImage { get; set; }

        public ArticleDetail(long articleId, string articleTitle, string articleCategory, string createDate, string articleDescription, string articleImage)
        {
            ArticleID = articleId;
            ArticleTitle = articleTitle;
            ArticleCategory = articleCategory;
            CreateDate = createDate;
            ArticleDescription = articleDescription;
            ArticleImage = articleImage;

        }

    }
}
