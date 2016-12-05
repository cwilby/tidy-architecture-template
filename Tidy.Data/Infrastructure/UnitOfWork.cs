using Tidy.Core.Infrastructure;
using $safeprojectname$.Context;

namespace $safeprojectname$.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;
        private TidyDataContext _dataContext;

        protected TidyDataContext DataContext => _dataContext ?? (_dataContext = _databaseFactory.GetDataContext());

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
