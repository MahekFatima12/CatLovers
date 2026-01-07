//namespace CatLoversAPI.Data
//{
//    public class CatDbContext
//    {
//    }

using Microsoft.EntityFrameworkCore;
using CatLoversAPI.Models;

namespace CatLoversAPI.Data
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


