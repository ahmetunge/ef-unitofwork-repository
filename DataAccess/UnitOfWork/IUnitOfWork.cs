namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();


    }
}