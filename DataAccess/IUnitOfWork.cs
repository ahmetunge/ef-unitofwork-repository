namespace EfCoreTransactionTest.Api.DataAccess
{
    public interface IUnitOfWork
    {
         void BeginTransaction();

         void RollBackTransaction();

         void CommitTransaction();

         void SaveChanges();
    }
}