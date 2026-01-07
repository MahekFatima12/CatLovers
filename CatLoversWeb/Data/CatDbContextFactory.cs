using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CatLoversWeb.Data
{
    public class CatDbContextFactory : IDesignTimeDbContextFactory<CatDbContext>
    {
        public CatDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=CatLoversDb;Trusted_Connection=True"
            );

            return new CatDbContext(optionsBuilder.Options);
        }
    }
}
