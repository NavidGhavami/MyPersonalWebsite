namespace _01_Query.Contract.EducationExperience
{
    public class EducationExperienceQueryModel
    {
        public long Id { get; set; }
        public string UniversityName { get; set; }
        public string EducationDegree { get; set; }
        public string EducationCourse { get; set; }
        public string EducationDate { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
    }
}
