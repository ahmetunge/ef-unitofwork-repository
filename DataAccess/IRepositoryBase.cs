using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EfCoreTransactionTest.Api.DataAccess
{
    public interface IRepositoryBase<T>
    {
         void Add(T entity);
         void Delete(T entity);

         void Update(T entity);

         T Get(Expression<Func<T, bool>> filter);

         IEnumerable<T> GetList(Expression<Func<T, bool>> filter);
    }
}