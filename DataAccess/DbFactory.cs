using System;
using EfCoreTransactionTest.Api.DataAccess.EntityFramework;

namespace EfCoreTransactionTest.Api.DataAccess
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly EfSQLDbContext _dbContext;
        public DbFactory(EfSQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EfSQLDbContext GetEfDbContext
        {
            get
            {
                return _dbContext;
            }
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}