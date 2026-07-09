using EStoreAdminModel.Models;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;

namespace EStoreAdminService.Services
{
    public class BrandService : IBrandService
    {
        private readonly BrandRepository _brandRepository;
        public BrandService(BrandRepository brandRepository)
        {
            this._brandRepository = brandRepository;
        }

        public List<BrandModel> ListBrands()
        {
            List<BrandModel> brandModels =
                this._brandRepository.Brands.ToList();
         
            return brandModels;

        }

    }
}
