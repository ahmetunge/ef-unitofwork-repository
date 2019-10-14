using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfRepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly EfSQLDbContext _dataContext;
        public EfRepositoryBase(IDbFactory dbFactory)
        {
            _dataContext = dbFactory.GetEfDbContext;
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