using System;
using EfCoreTransactionTest.Api.DataAccess;
using EfCoreTransactionTest.Api.DataAccess.UnitOfWork;
using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public class ArticleBusiness : IArticleBusiness
    {
        private readonly IMsSqlUnitOfWork _msSqlUnitOfWork;
        private readonly IArticleRepository _articleRepository;

        public ArticleBusiness(
            IMsSqlUnitOfWork msSqlUnitOfWork,
            IArticleRepository articleRepository
            )
        {
            _msSqlUnitOfWork = msSqlUnitOfWork;
            _articleRepository = articleRepository;
        }

        public void AddToMsSql(Article article)
        {
            Article art = GetArticle();

            _articleRepository.Add(art);
            _msSqlUnitOfWork.SaveChanges();

        }

        public void AddToMsSqlWithTransaction(Article article)
        {
            try
            {
                _msSqlUnitOfWork.BeginTransaction();

                Article article1 = GetArticle();
                _articleRepository.Add(article1);

                _msSqlUnitOfWork.SaveChanges();

                Article article2 = GetArticle();
                _articleRepository.Add(article2);

                throw new Exception();
                
                _msSqlUnitOfWork.SaveChanges();

                _msSqlUnitOfWork.Commit();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                _msSqlUnitOfWork.RollBack();
            }
        }


        private Article GetArticle()
        {
            string dateNow = DateTime.Now.Date.ToString();
            Article article = new Article();

            article.CategoryId = 2;
            article.Content = "Article Content-" + dateNow + "-" + Guid.NewGuid();
            article.IsActive = true;
            article.Title = "Article Title-" + dateNow + "-" + Guid.NewGuid();

            return article;

        }

    }
}