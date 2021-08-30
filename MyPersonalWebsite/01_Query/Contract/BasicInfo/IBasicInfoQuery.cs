using _01_Query.Contract.ArticleCategory;

namespace _01_Query.Contract.BasicInfo
{
    public interface IBasicInfoQuery
    {
        BasicInfoQueryModel GetBasicInformation();
        string PersianResume();
        string EnglishResume();
        string RecommendationLetter();
    }
}
