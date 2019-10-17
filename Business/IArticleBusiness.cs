using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public interface IArticleBusiness
    {
        void AddToMsSql(Article article);
        void AddToMsSqlWithTransaction(Article article);
    }
}