using EfCoreTransactionTest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfSQLDbContext : DbContext
    {
        public EfSQLDbContext(DbContextOptions<EfSQLDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}