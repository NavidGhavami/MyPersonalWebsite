using Microsoft.EntityFrameworkCore;
using PersonalInfo.Domain.BasicInformation;
using PersonalInfoManagement.Infrastructure.EFCore.Mapping;

namespace PersonalInfoManagement.Infrastructure.EFCore
{
    public class PersonalInfoContext : DbContext
    {
        public DbSet<BasicInformation> BasicInformations { get; set; }

        public PersonalInfoContext(DbContextOptions<PersonalInfoContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(BasicInfoMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
