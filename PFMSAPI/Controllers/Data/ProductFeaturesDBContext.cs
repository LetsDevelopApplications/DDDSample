using Microsoft.EntityFrameworkCore;
using PFMSAPI.Models;


namespace PFMSAPI.Controllers.Data
{
    public class ProductFeaturesDBContext : DbContext
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ProductFeaturesDb");
        }

        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public bool HasChanges()
        {
            // Check if there are any tracked entities with modifications
            return ChangeTracker.HasChanges();
        }
    }
}
