using $ext_projectname$.Core.Domain.Identity;
using $safeprojectname$.Infrastructure;
using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace $safeprojectname$.Configuration.Identity
{
    [Export(typeof(IEntityConfiguration))]
    public class UserConfiguration : EntityTypeConfiguration<User>, IEntityConfiguration
    {
        public UserConfiguration()
        {
            Property(u => u.Id).HasColumnName("UserId");

            HasMany(u => u.Roles).WithRequired(ur => ur.User).HasForeignKey(ur => ur.UserId);
        }

        public void AddConfiguration(ConfigurationRegistrar registrar)
        {
            registrar.Add(this);
        }
    }
}
