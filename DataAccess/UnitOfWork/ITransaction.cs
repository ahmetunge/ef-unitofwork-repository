namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork
{
    public interface ITransaction:IUnitOfWork,ISaveChanges
    {
          void Begin();
    }
}