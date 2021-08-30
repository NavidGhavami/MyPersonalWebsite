using System.Linq;
using _01_Query.Contract.BasicInfo;
using BlogManagement.Infrastructure.EFCore;
using PersonalInfoManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
    public class BasicInfoQuery : IBasicInfoQuery
    {
        private readonly PersonalInfoContext _personalInfoContext;
        private readonly BlogContext _blogContext;

        public BasicInfoQuery(PersonalInfoContext personalInfoContext, BlogContext blogContext)
        {
            _personalInfoContext = personalInfoContext;
            _blogContext = blogContext;
        }

        public BasicInfoQueryModel GetBasicInformation()
        {
            var articleCount = _blogContext.Articles.Count();

           return  _personalInfoContext.BasicInformations.Select(x=> new BasicInfoQueryModel
            {
                Name = x.Name,
                Family = x.Family,
                Age = x.Age,
                Nationality = x.Nationality,
                Job = x.Job,
                Address = x.Address,
                Email = x.Email,
                Mobile = x.Mobile,
                Instagram = x.Instagram,
                Language = x.Language,
                Experience = x.Experience,
                CompleteProject = x.CompleteProject,
                HappyCustomers = x.HappyCustomers,
                Articles = x.Articles,
                ArticleCount = articleCount


           }).First();

           
        }

        public string PersianResume()
        {
            var persianResume = _personalInfoContext.BasicInformations.First();

            if (persianResume == null)
            {
                return new string("");
            }

            return persianResume.PersianResume;
        }

        public string EnglishResume()
        {
            var englishResume = _personalInfoContext.BasicInformations.First();

            if (englishResume == null)
            {
                return new string("");
            }

            return englishResume.EnglishResume;
        }

        public string RecommendationLetter()
        {
            var recommendationLetter = _personalInfoContext.BasicInformations.FirstOrDefault();

            if (recommendationLetter == null)
            {
                return new string("");
            }

            return recommendationLetter.RecommendationLetters;
        }

    }
}
