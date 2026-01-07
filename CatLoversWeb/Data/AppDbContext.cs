using Microsoft.EntityFrameworkCore;
using CatLoversWeb.Models;

namespace CatLoversWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
    }
}

