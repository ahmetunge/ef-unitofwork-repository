using EfCoreTransactionTest.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTransactionTest.Api.DataAccess.EntityFramework
{
    public class EfMsSqlDbContext : DbContext
    {
        public EfMsSqlDbContext(DbContextOptions<EfMsSqlDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}