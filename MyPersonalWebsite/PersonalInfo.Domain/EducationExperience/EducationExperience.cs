using _0_Framework.Domain;

namespace PersonalInfo.Domain.EducationExperience
{
    public class EducationExperience : EntityBase
    {
        public string UniversityName { get; private set; }
        public string EducationDegree { get; private set; }
        public string EducationCourse { get; private set; }
        public string EducationDate { get; private set; }
        public string Description { get; private set; }
        public bool IsRemoved { get; private set; }

        public EducationExperience(string universityName, string educationDegree, string educationCourse, string educationDate, string description)
        {
            UniversityName = universityName;
            EducationDegree = educationDegree;
            EducationCourse = educationCourse;
            EducationDate = educationDate;
            Description = description;
            IsRemoved = false;
        }

        public void Edit(string universityName, string educationDegree, string educationCourse, string educationDate, string description)
        {
            UniversityName = universityName;
            EducationDegree = educationDegree;
            EducationCourse = educationCourse;
            EducationDate = educationDate;
            Description = description;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
