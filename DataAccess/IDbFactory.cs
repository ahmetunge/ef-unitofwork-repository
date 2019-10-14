using EfCoreTransactionTest.Api.DataAccess.EntityFramework;

namespace EfCoreTransactionTest.Api.DataAccess
{
    public interface IDbFactory
    {
         EfSQLDbContext GetEfDbContext{get;}
    }
}