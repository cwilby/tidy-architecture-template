using Tidy.Core.Domain.Identity;
using Tidy.Core.Repository.Identity;
using $safeprojectname$.Infrastructure;

namespace $safeprojectname$.Repository.Identity
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { 
        }
    }
}
