using $safeprojectname$.Infrastructure;
using Tidy.Core.Domain.Identity;
using Tidy.Core.Extensions;
using Tidy.Core.Infrastructure;
using Tidy.Core.Repository.Identity;
using Tidy.Data.Identity;
using Tidy.Data.Infrastructure;
using Tidy.Data.Repository.Identity;
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