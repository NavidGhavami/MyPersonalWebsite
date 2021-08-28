using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceManagement.Domain.Services;

namespace ServiceManagements.Infrastructure.EFCore.Mapping
{
    public class ServiceMapping : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ServiceName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ServiceLogo).IsRequired().HasMaxLength(150);
            builder.Property(x => x.ServiceDescription).IsRequired();
        }
    }
}
