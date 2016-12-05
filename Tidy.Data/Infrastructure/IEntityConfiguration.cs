using System.Data.Entity.ModelConfiguration.Configuration;

namespace $safeprojectname$.Infrastructure
{
    public interface IEntityConfiguration
    {
        void AddConfiguration(ConfigurationRegistrar registrar);
    }
}
