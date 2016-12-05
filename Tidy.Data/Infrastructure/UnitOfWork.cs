using $ext_projectname$.Core.Infrastructure;
using $safeprojectname$.Context;

namespace $safeprojectname$.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;
        private $ext_projectname$DataContext _dataContext;

        protected $ext_projectname$DataContext DataContext => _dataContext ?? (_dataContext = _databaseFactory.GetDataContext());

        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }
    }
}
