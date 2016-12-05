using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;
using System.Reflection;
using $ext_projectname$.Core.Domain.Identity;
using $safeprojectname$.Infrastructure;

namespace $safeprojectname$.Context
{
    public class $ext_projectname$DataContext : DbContext
    {
        public $ext_projectname$DataContext() : base("$ext_projectname$")
        {
            // https://gist.github.com/brainwipe/7661942
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        #region Identity
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // http://odetocode.com/blogs/scott/archive/2011/11/28/composing-entity-framework-fluent-configurations.aspx

            var contextConfiguration = new ContextConfiguration();
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            container.ComposeParts(contextConfiguration);

            foreach (var configuration in contextConfiguration.Configurations)
            {
                configuration.AddConfiguration(modelBuilder.Configurations);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
