using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Models.Products;
using EStoreAdminModel.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace EStoreAdminRepository.Repository
{
    public class ProductRepository : DbContext
    {

        public ProductRepository(DbContextOptions<ProductRepository> options)
            : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductModel>().ToTable("Products");

            modelBuilder.Entity<ProductModel>().HasKey("Id");

            modelBuilder.Entity<BrandModel>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Brands)
                .HasForeignKey(e => e.BrandId)
                .IsRequired();

            modelBuilder.Entity<TypeModel>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Types)
                .HasForeignKey(e => e.TypeId)
                .IsRequired();


        }
    }
}
