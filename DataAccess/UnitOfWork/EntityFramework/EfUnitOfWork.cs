using System;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.UnitOfWork.EntityFramework
{
    public class EfUnitOfWork :IUnitOfWork
    {
        private readonly DbContext _context;
        public EfUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void BeginTransactionAsync()
        {
             _context.Database.BeginTransactionAsync();
        }


        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}