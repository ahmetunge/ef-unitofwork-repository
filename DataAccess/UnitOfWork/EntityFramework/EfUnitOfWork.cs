using System;

namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork,ITransaction,ITransactionAsync,ISaveChanges,ISaveChangesAsync
    {
        private readonly IDbFactory _dbFactory;
        public EfUnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Begin()
        {
            _dbFactory.GetEfDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbFactory.GetEfDbContext.Database.CommitTransaction();
        }

        public void SaveChanges()
        {
            _dbFactory.GetEfDbContext.SaveChanges();
        }

        public void RollBack()
        {
            _dbFactory.GetEfDbContext.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            _dbFactory.GetEfDbContext.Dispose();
        }

        public void BeginAsync()
        {
             _dbFactory.GetEfDbContext.Database.BeginTransactionAsync();
        }


        public void SaveChangesAsync()
        {
            _dbFactory.GetEfDbContext.SaveChangesAsync();
        }
    }
}