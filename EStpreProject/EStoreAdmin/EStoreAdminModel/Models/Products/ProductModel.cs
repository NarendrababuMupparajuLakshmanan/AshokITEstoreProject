using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Models.Types;

namespace EStoreAdminModel.Models.Products
{
    public class ProductModel
    {
        public Guid Id { get; set;  }

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public Guid BrandId { get; set; }

        public BrandModel Brands { get; set; }
        
        public Guid TypeId { get; set; }

        public TypeModel Types { get; set; }

        public string ImageName { get; set;  } = string.Empty;

        public string ImageUrl { get; set;  } = string.Empty;

        public int ProductCost { get; set; }

        public int GST { get; set; }

        public int TotalCost { get; set; }
    }
}
