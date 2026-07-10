using EStoreAdminModel.Models;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace EStoreAdminService.Services
{
    public class BrandService : IBrandService
    {
        private readonly BrandRepository _brandRepository;
        public BrandService(BrandRepository brandRepository)
        {
            this._brandRepository = brandRepository;
        }

        public void CreateBrand(CreateBrandModel createBrandModel)
        {
            if (createBrandModel == null)
            {
                throw new ArgumentNullException(nameof(createBrandModel));
            }

            BrandModel brandModel = new BrandModel()
            {
                Id = Guid.NewGuid(),
                Name = createBrandModel.Name
            };

            this._brandRepository.Brands.Add(brandModel);
            this._brandRepository.SaveChanges();

        }

        public List<BrandModel> ListBrands()
        {
            List<BrandModel> brandModels =
                this._brandRepository.Brands.ToList();
         
            return brandModels;

        }

    }
}
