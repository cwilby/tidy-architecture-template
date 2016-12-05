using $ext_projectname$.Core.Infrastructure;
using $safeprojectname$.Context;
using System;

namespace $safeprojectname$.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private readonly $ext_projectname$DataContext _dataContext;

        public $ext_projectname$DataContext GetDataContext()
        {
            return _dataContext ?? new $ext_projectname$DataContext();
        }

        public DatabaseFactory()
        {
            _dataContext = new $ext_projectname$DataContext();
        }

        protected override void DisposeCore()
        {
            _dataContext?.Dispose();
        }
    }
    public interface IDatabaseFactory : IDisposable
    {
        $ext_projectname$DataContext GetDataContext();
    }
}
