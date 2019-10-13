using System;

namespace EfCoreTransactionTest.Api.Models
{
   public class Article 
    {
        public Article()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; private set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public bool IsActive { get; set; }
    }
}