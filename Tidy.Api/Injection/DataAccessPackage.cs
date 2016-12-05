using Tidy.Core.Infrastructure;
using Tidy.Data.Infrastructure;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace $safeprojectname$.Injection
{
    public class DataAccessPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IDatabaseInitializer, MigrationsInitializer>();
            container.Register<IDatabaseFactory, DatabaseFactory>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>();
        }
    }
}