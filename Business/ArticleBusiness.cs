using System;
using EfCoreTransactionTest.Api.DataAccess;
using EfCoreTransactionTest.Api.Models;

namespace EfCoreTransactionTest.Api.Business
{
    public class ArticleBusiness : IArticleBusiness
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ArticleBusiness(IArticleRepository ArticleRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _articleRepository = ArticleRepository;

        }
        public void AddWithTransaction(Article article)
        {
            if (article == null)
                throw new Exception("Article cannot be null");

            try
            {
                _unitOfWork.BeginTransaction();

                Article article1 = new Article
                {
                    Title = "Title 4",
                    Content = "Content 4",
                    CategoryId = 5,
                    IsActive = true
                };

                _articleRepository.Add(article1);

                _unitOfWork.SaveChanges();

                Article article2 = new Article
                {
                    Title = "Title 5",
                    Content = "Content 5",
                    CategoryId = 5,
                    IsActive = true
                };
                _articleRepository.Add(article2);

                _unitOfWork.SaveChanges();

                Article article3 = new Article
                {
                    Title = "Title 6",
                    Content = "Content 3",
                    CategoryId = 5,
                    IsActive = true
                };

                _articleRepository.Add(article3);

                _unitOfWork.SaveChanges();

                _unitOfWork.CommitTransaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTransaction();

                throw new Exception(ex.Message);
            }


        }


        public void Add(Article article)
        {
            Article article5 = new Article
            {
                Title = "Title 5",
                Content = "Content 5",
                CategoryId = 5,
                IsActive = true
            };

            _articleRepository.Add(article5);

            Article article6 = new Article
            {
                Title = "Title 6",
                Content = "Content 6",
                CategoryId = 5,
                IsActive = true
            };

            //  throw new Exception();
            _articleRepository.Add(article6);

            _unitOfWork.SaveChanges();
        }
    }
}