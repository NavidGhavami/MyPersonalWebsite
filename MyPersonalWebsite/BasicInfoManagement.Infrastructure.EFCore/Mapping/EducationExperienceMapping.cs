using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInfo.Domain.EducationExperience;

namespace PersonalInfoManagement.Infrastructure.EFCore.Mapping
{
    public class EducationExperienceMapping : IEntityTypeConfiguration<EducationExperience>
    {
        public void Configure(EntityTypeBuilder<EducationExperience> builder)
        {
            builder.ToTable("EducationExperience");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UniversityName).IsRequired().HasMaxLength(550);
            builder.Property(x => x.EducationCourse).IsRequired().HasMaxLength(550);
            builder.Property(x => x.EducationDegree).IsRequired().HasMaxLength(550);
            builder.Property(x => x.EducationDate).IsRequired().HasMaxLength(550);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
