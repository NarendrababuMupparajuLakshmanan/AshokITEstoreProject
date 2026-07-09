using EStoreAdminModel.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreAdminRepository.Repository
{
    public class BrandRepository : DbContext
    {

        public BrandRepository(DbContextOptions<BrandRepository> options)
            : base(options)
        {

        }

        public DbSet<BrandModel> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<BrandModel>().ToTable("Brands");

            //modelBuilder.Entity<BrandModel>().HasData(
            //    new BrandModel()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Reliance"
            //    },
            //    new BrandModel()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Samsung"
            //    },
            //      new BrandModel()
            //      {
            //          Id = Guid.NewGuid(),
            //          Name = "Airtel"
            //      }

            //    );
        }

    }
}
