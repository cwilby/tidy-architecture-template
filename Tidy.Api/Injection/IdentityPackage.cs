using $safeprojectname$.Infrastructure;
using $ext_projectname$.Core.Domain.Identity;
using $ext_projectname$.Core.Infrastructure;
using $ext_projectname$.Core.Repository.Identity;
using $ext_projectname$.Data.Identity;
using Microsoft.AspNet.Identity;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace $safeprojectname$.Injection
{
    public class IdentityPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<IUserStore<User, int>, UserStore>(Lifestyle.Scoped);
            container.Register<ISession, Session>();
        }
    }
}