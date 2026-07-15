using EStoreAdminModel.Models.Products;

namespace EStoreAdminModel.Models.Brands
{
    public class BrandModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<ProductModel> Products { get; set; }
    }
}
