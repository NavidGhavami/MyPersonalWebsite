using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInfo.Domain.JobExperience;

namespace PersonalInfoManagement.Infrastructure.EFCore.Mapping
{
    public class JobExperienceMapping : IEntityTypeConfiguration<JobExperience>
    {
        public void Configure(EntityTypeBuilder<JobExperience> builder)
        {
            builder.ToTable("JobExperience");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(550);
            builder.Property(x => x.JobPosition).IsRequired().HasMaxLength(550);
            builder.Property(x => x.WorkDate).IsRequired().HasMaxLength(550);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
