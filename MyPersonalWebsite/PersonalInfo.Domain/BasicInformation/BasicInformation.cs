using _0_Framework.Domain;

namespace PersonalInfo.Domain.BasicInformation
{
    public class BasicInformation : EntityBase
    {
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Age { get; private set; }
        public string Nationality { get; private set; }
        public string Job { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string Mobile { get; private set; }
        public string Instagram { get; private set; }
        public string Language { get; private set; }
        public string Experience { get; private set; }
        public string CompleteProject { get; private set; }
        public string HappyCustomers { get; private set; }
        public string Articles { get; private set; }
        public string PersianResume { get; private set; }
        public string EnglishResume { get; private set; }
        public string RecommendationLetters { get; private set; }


        public BasicInformation(string name, string family, string age, string nationality, string job, string address, string email, string mobile,
            string instagram, string language, string experience, string completeProject, string happyCustomers, string articles, string persianResume,
            string englishResume, string recommendationLetters)
        {
            Name = name;
            Family = family;
            Age = age;
            Nationality = nationality;
            Job = job;
            Address = address;
            Email = email;
            Mobile = mobile;
            Instagram = instagram;
            Language = language;
            Experience = experience;
            CompleteProject = completeProject;
            HappyCustomers = happyCustomers;
            Articles = articles;
            PersianResume = persianResume;
            EnglishResume = englishResume;
            RecommendationLetters = recommendationLetters;
        }

        public void Edit(string name, string family, string age, string nationality, string job, string address, string email, string mobile,
            string instagram, string language, string experience, string completeProject, string happyCustomers, string articles, string persianResume,
            string englishResume, string recommendationLetters)
        {
            Name = name;
            Family = family;
            Age = age;
            Nationality = nationality;
            Job = job;
            Address = address;
            Email = email;
            Mobile = mobile;
            Instagram = instagram;
            Language = language;
            Experience = experience;
            CompleteProject = completeProject;
            HappyCustomers = happyCustomers;
            Articles = articles;

            if (!string.IsNullOrWhiteSpace(persianResume))
            {
                PersianResume = persianResume;
            }
            if (!string.IsNullOrWhiteSpace(englishResume))
            {
                EnglishResume = englishResume;
            }
            if (!string.IsNullOrWhiteSpace(recommendationLetters))
            {
                RecommendationLetters = recommendationLetters;
            }
        }
    }
}
