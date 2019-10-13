using EfCoreTransactionTest.Api.DataAccess.EntityFramework;

namespace EfCoreTransactionTest.Api.DataAccess
{
    public interface IDbFactory
    {
         EfDbContext GetEfDbContext{get;}
    }
}