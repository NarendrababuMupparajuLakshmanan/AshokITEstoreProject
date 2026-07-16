using EStoreAdminModel.Models.Products;

namespace EStoreAdminModel.ServiceContracts
{
    public interface IProductService
    {
        List<ProductModel> ListProducts();
    }
}
