using EfCoreTransactionTest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}