using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public interface IArticleBusiness
    {
         void Add(Article product);
    }
}