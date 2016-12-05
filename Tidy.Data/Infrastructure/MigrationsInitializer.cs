using $ext_projectname$.Core.Infrastructure;
using $safeprojectname$.Context;
using System.Data.Entity;

namespace $safeprojectname$.Infrastructure
{
    public class MigrationsInitializer : IDatabaseInitializer
    {
        public void Initialize()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<$ext_projectname$DataContext, Migrations.Configuration>());
        }
    }
}
