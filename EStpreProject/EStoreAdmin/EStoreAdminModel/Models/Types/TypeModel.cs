using EStoreAdminModel.Models.Products;

namespace EStoreAdminModel.Models.Types
{
    public class TypeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<ProductModel> Products { get; set; }
    }
}
