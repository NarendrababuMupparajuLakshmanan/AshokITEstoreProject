using EStoreAdminModel.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace EStoreAdminRepository.Repository
{
    public class TypeRepository : DbContext
    {
        public TypeRepository(DbContextOptions<TypeRepository> options)
            : base(options) 
        {
            
        }

        public DbSet<TypeModel> Types { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<TypeModel>().ToTable("Types");

            //modelBuilder.Entity<TypeModel>().HasKey(t => t.Id);

            //modelBuilder.Entity<TypeModel>().
            //    Property(t => t.Name).IsRequired().HasMaxLength(100);

            //modelBuilder.Entity<TypeModel>().HasData(
            //    new TypeModel { Id = Guid.NewGuid(), Name = "Gadgets" },
            //    new TypeModel { Id = Guid.NewGuid(), Name = "Mobile" },
            //    new TypeModel { Id = Guid.NewGuid(), Name = "Television" }
            //);
        }
    }
}
