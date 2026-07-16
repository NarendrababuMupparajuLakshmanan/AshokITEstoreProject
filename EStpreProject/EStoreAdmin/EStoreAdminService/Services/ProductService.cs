using EStoreAdminModel.Models.Products;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;

namespace EStoreAdminService.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductModel> ListProducts()
        {
            List<ProductModel> productModels =
                this._productRepository.Products.ToList();

            return productModels;
        }
    }
}
