using $ext_projectname$.Core.Domain.Identity;
using $ext_projectname$.Core.Repository.Identity;
using $safeprojectname$.Infrastructure;

namespace $safeprojectname$.Repository.Identity
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { 
        }
    }
}
