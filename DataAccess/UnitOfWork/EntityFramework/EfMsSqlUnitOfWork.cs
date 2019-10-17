using EfCoreTransactionTest.Api.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork.EntityFramework
{
    public class EfMsSqlUnitOfWork : EfUnitOfWork, IMsSqlUnitOfWork
    {
        public EfMsSqlUnitOfWork(EfMsSqlDbContext context) : base(context)
        {
        }
    }
}