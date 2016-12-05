using $safeprojectname$.Domain.Identity;

namespace $safeprojectname$.Infrastructure
{
    public interface ISession
    {
        User CurrentUser { get; }
    }
}
