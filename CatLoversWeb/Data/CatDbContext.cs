using Microsoft.EntityFrameworkCore;
using CatLoversWeb.Models;

namespace CatLoversWeb.Data
{
    public class CatDbContext : DbContext
    {
        public CatDbContext(DbContextOptions<CatDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
    }
}

