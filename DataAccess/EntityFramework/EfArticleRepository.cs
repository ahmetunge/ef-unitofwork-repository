using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfArticleRepository : EfRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(EfMsSqlDbContext context) : base(context)
        {
        }
    }
}