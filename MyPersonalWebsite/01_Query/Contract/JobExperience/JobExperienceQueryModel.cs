namespace _01_Query.Contract.JobExperience
{
    public class JobExperienceQueryModel
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string JobPosition { get; set; }
        public string WorkDate { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
    }
}
