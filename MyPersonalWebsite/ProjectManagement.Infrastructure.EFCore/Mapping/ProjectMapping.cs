using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagement.Domain.Project;

namespace ProjectManagement.Infrastructure.EFCore.Mapping
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.ToTable("Projects");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Customer).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Technology).IsRequired().HasMaxLength(550);
            builder.Property(x => x.FirstPicture).IsRequired();
            builder.Property(x => x.SecondPicture).IsRequired();
            builder.Property(x => x.ThirdPicture).IsRequired();
            builder.Property(x => x.ForthPicture).IsRequired();
            builder.Property(x => x.PictureAlt).IsRequired();
            builder.Property(x => x.PictureTitle).IsRequired();
            builder.Property(x => x.Slug).IsRequired();
            builder.Property(x => x.UrlLink).IsRequired();
            builder.Property(x => x.Description).IsRequired();



            builder.HasOne(x => x.Category)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
