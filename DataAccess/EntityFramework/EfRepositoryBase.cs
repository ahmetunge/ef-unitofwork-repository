using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DbContext _dataContext;
        public EfRepositoryBase(DbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(T entity)
        {
            _dataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dataContext.Set<T>().SingleOrDefault(filter);
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            var list = filter == null
                   ? _dataContext.Set<T>().ToList()
                   : _dataContext.Set<T>().Where(filter).ToList();

            return list;
        }

        public void Update(T entity)
        {
            _dataContext.Set<T>().Update(entity);
        }
    }
}