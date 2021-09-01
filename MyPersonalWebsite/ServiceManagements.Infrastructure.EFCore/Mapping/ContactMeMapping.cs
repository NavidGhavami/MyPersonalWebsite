using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceManagement.Domain.ContactMe;

namespace ServiceManagements.Infrastructure.EFCore.Mapping
{
    public class ContactMeMapping : IEntityTypeConfiguration<ContactMe>
    {
        public void Configure(EntityTypeBuilder<ContactMe> builder)
        {
            builder.ToTable("ContactMe");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Message).IsRequired();
        }
    }
}
