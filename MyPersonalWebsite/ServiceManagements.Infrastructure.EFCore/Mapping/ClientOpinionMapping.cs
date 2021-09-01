using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceManagement.Domain.ClientsOpinion;

namespace ServiceManagements.Infrastructure.EFCore.Mapping
{
    public class ClientOpinionMapping : IEntityTypeConfiguration<ClientsOpinion>
    {
        public void Configure(EntityTypeBuilder<ClientsOpinion> builder)
        {
            builder.ToTable("ClientsOpinion");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClientName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ClientJob).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
