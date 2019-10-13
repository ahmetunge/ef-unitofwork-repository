using System;
using EfCoreTransactionTest.Api.DataAccess.EntityFramework;

namespace EfCoreTransactionTest.Api.DataAccess
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly EfDbContext _dbContext;
        public DbFactory(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EfDbContext GetEfDbContext
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