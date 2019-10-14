using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public interface IArticleBusiness
    {
        void AddWithTransactionAsync(Article article);
        void AddWithTransaction(Article article);
        void Add(Article article);
        void AddAsync(Article article);
    }
}