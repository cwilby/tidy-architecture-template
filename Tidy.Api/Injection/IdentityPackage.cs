using $safeprojectname$.Infrastructure;
using Tidy.Core.Domain.Identity;
using Tidy.Core.Infrastructure;
using Tidy.Core.Repository.Identity;
using Tidy.Data.Identity;
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