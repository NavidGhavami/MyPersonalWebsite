using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalInfo.Domain.BasicInformation;

namespace PersonalInfoManagement.Infrastructure.EFCore.Mapping
{
    public class BasicInfoMapping : IEntityTypeConfiguration<BasicInformation>
    {
        public void Configure(EntityTypeBuilder<BasicInformation> builder)
        {
            builder.ToTable("BasicInformations");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Family).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Nationality).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Job).IsRequired().HasMaxLength(450);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Instagram).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Language).IsRequired().HasMaxLength(550);
            builder.Property(x => x.Experience).IsRequired().HasMaxLength(80);
            builder.Property(x => x.CompleteProject).IsRequired().HasMaxLength(80);
            builder.Property(x => x.HappyCustomers).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Articles).IsRequired().HasMaxLength(80);

            builder.Property(x => x.PersianResume).IsRequired();
            builder.Property(x => x.EnglishResume).IsRequired();
            builder.Property(x => x.RecommendationLetters).IsRequired();
        }
    }
}
