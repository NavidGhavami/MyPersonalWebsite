using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceManagement.Domain.Customers;

namespace ServiceManagements.Infrastructure.EFCore.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CustomerLogo).IsRequired();
            builder.Property(x => x.LogoAlt).IsRequired().HasMaxLength(350);
            builder.Property(x => x.LogoTitle).IsRequired().HasMaxLength(350);
        }
    }
}
