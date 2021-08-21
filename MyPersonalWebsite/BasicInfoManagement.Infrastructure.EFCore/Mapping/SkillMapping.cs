using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInfo.Domain.Skills;

namespace PersonalInfoManagement.Infrastructure.EFCore.Mapping
{
    public class SkillMapping : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.ToTable("Skills");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SkillName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.SkillPercent).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ShowOrder).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
