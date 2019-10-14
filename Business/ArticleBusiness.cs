using System;
using EfCoreTransactionTest.Api.DataAccess;
using EfCoreTransactionTest.Api.DataAccess.UnitOfWork;
using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public class ArticleBusiness : IArticleBusiness
    {
        private readonly ITransactionAsync _transactionAsync;
        private readonly ITransaction _transaction;
        private readonly ISaveChanges _saveChanges;
        private readonly ISaveChangesAsync _saveChangesAsync;

        public ArticleBusiness(
            ITransactionAsync transactionAsync, 
            ITransaction transaction,
            ISaveChanges saveChanges,
            ISaveChangesAsync saveChangesAsync
            )
        {
            _transactionAsync = transactionAsync;
            _transaction = transaction;
            _saveChanges = saveChanges;
            _saveChangesAsync = saveChangesAsync;
        }

        public void Add(Article article)
        {
            _saveChanges.SaveChanges();
        }

        public void AddAsync(Article article)
        {
            _saveChangesAsync.SaveChangesAsync();
        }

        public void AddWithTransaction(Article article)
        {
            _transaction.Begin();
            _transaction.SaveChanges();
            _transaction.Commit();
            _transaction.RollBack();
        }

        public void AddWithTransactionAsync(Article article)
        {
            _transactionAsync.BeginAsync();
            _transactionAsync.SaveChangesAsync();
            _transactionAsync.Commit();
            _transactionAsync.RollBack();
        }
    }
}