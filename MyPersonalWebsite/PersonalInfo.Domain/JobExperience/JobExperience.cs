using _0_Framework.Domain;

namespace PersonalInfo.Domain.JobExperience
{
    public class JobExperience : EntityBase
    {
        public string CompanyName { get; private set; }
        public string JobPosition { get; private set; }
        public string WorkDate { get; private set; }
        public string Description { get; private set; }
        public bool IsRemoved { get; private set; }


        public JobExperience(string companyName, string jobPosition, string workDate, string description)
        {
            CompanyName = companyName;
            JobPosition = jobPosition;
            WorkDate = workDate;
            Description = description;
            IsRemoved = false;
        }

        public void Edit(string companyName, string jobPosition, string workDate, string description)
        {
            CompanyName = companyName;
            JobPosition = jobPosition;
            WorkDate = workDate;
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
