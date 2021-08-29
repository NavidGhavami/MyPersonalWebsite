using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceManagement.Domain.Plans;

namespace ServiceManagements.Infrastructure.EFCore.Mapping
{
    public class PlanMapping : IEntityTypeConfiguration<Plans>
    {
        public void Configure(EntityTypeBuilder<Plans> builder)
        {
            builder.ToTable("Plans");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PlanName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.PlanPrice).IsRequired().HasMaxLength(350);
            builder.Property(x => x.PlanDescription1);
            builder.Property(x => x.PlanDescription2);
            builder.Property(x => x.PlanDescription3);
            builder.Property(x => x.PlanDescription4);
            builder.Property(x => x.PlanDescription5);
            builder.Property(x => x.PlanDescription6);
            builder.Property(x => x.PlanDescription7);
            builder.Property(x => x.PlanDescription8);
            builder.Property(x => x.PlanDescription9);
            builder.Property(x => x.PlanDescription10);

        }
    }
}
