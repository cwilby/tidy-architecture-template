using Tidy.Core.Infrastructure;
using $safeprojectname$.Context;
using System;

namespace $safeprojectname$.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private readonly TidyDataContext _dataContext;

        public TidyDataContext GetDataContext()
        {
            return _dataContext ?? new TidyDataContext();
        }

        public DatabaseFactory()
        {
            _dataContext = new TidyDataContext();
        }

        protected override void DisposeCore()
        {
            _dataContext?.Dispose();
        }
    }
    public interface IDatabaseFactory : IDisposable
    {
        TidyDataContext GetDataContext();
    }
}
