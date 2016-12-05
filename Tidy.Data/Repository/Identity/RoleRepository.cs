using $ext_projectname$.Core.Domain.Identity;
using $ext_projectname$.Core.Repository.Identity;
using $safeprojectname$.Infrastructure;

namespace $safeprojectname$.Repository.Identity
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { 
        }
    }
}
