namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork
{
    public interface ITransactionAsync:IUnitOfWork,ISaveChangesAsync
    {
        void BeginAsync();

    }
}