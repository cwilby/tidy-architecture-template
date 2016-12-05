using Tidy.Core.Domain.Identity;
using $safeprojectname$.Infrastructure;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace $safeprojectname$.Configuration.Identity
{
    [Export(typeof(IEntityConfiguration))]
    public class RoleConfiguration : EntityTypeConfiguration<Role>, IEntityConfiguration
    {
        public RoleConfiguration()
        {
            Property(r => r.Id).HasColumnName("RoleId");

            HasMany(r => r.Users).WithRequired(ur => ur.Role).HasForeignKey(ur => ur.RoleId);
        }

        public void AddConfiguration(ConfigurationRegistrar registrar)
        {
            registrar.Add(this);
        }
    }
}
