using System.Collections.Generic;

namespace _01_Query.Contract
{
    public interface IBasicInfoQuery
    {
        BasicInfoQueryModel GetBasicInformation();
        string PersianResume();
        string EnglishResume();
        string RecommendationLetter();
    }
}
