namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        public EfUnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void BeginTransaction()
        {
            _dbFactory.GetEfDbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbFactory.GetEfDbContext.Database.CommitTransaction();
        }

        public void SaveChanges()
        {
            _dbFactory.GetEfDbContext.SaveChanges();
        }

        public void RollBackTransaction()
        {
            _dbFactory.GetEfDbContext.Database.RollbackTransaction();
        }
    }
}