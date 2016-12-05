using $safeprojectname$.Infrastructure;
using $ext_projectname$.Core.Domain.Identity;
using $ext_projectname$.Core.Extensions;
using $ext_projectname$.Core.Infrastructure;
using $ext_projectname$.Core.Repository.Identity;
using $ext_projectname$.Data.Identity;
using $ext_projectname$.Data.Infrastructure;
using $ext_projectname$.Data.Repository.Identity;
using Microsoft.AspNet.Identity;
using Owin;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System.Linq;

namespace $safeprojectname$
{
    public partial class Startup
    {
        public Container ConfigureSimpleInjector(IAppBuilder app)
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new ExecutionContextScopeLifestyle();

            container.RegisterPackages();  

            app.Use(async (context, next) =>
            {
                using (container.BeginExecutionContextScope())
                {
                    await next();
                }
            });

            container.Verify();

            return container;
        }
    }
}