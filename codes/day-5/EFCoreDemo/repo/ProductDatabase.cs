using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.repo
{
    public class ProductDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=joydip-pc\sqlexpress;database=sampledb;integrated security=sspi;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
