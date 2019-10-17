namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
        void BeginTransaction();

        void BeginTransactionAsync();

        void SaveChanges();

        void SaveChangesAsync();
    }
}