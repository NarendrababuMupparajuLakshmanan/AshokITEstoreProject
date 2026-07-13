using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using EStoreAdminService.Exceptions;
using EStoreAdminModel.Models.Brands;

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

        public void DeleteBrand(Guid id)
        {
            if (id == Guid.Empty)
                throw new BrandIdNotNullException("Brand Id is not empty");

            BrandModel? brandModel =
                this._brandRepository.Brands.Where(e => e.Id == id).FirstOrDefault();

            if (brandModel == null)
                throw new BrandNotNullException("Brand Model is Empty");

            this._brandRepository.Brands.Remove(brandModel);
            this._brandRepository.SaveChanges();

        }

        public UpdateBrandModel GetBrandById(Guid id)
        {
            if (id == Guid.Empty)
                throw new BrandIdNotNullException("Brand Id is not empty");

            BrandModel? brandModel = 
                this._brandRepository.Brands.Where(e => e.Id == id).FirstOrDefault();

            if (brandModel == null)
                throw new BrandNotNullException("Brand Model is Empty");

            UpdateBrandModel updateBrandModel =
                new UpdateBrandModel()
                {
                    Id = brandModel.Id,
                    Name = brandModel.Name
                };

            return updateBrandModel;
        }

        public List<BrandModel> ListBrands()
        {
            List<BrandModel> brandModels =
                this._brandRepository.Brands.ToList();

            return brandModels;

        }

        public void UpdateBrand(UpdateBrandModel updateBrandModel)
        {
            if (updateBrandModel == null)
                throw new BrandNotNullException("Update Brand Data is not null");

            BrandModel brandModel = new BrandModel()
            {
                Id = updateBrandModel.Id,
                Name = updateBrandModel.Name
            };

            this._brandRepository.Brands.Update(brandModel);
            this._brandRepository.SaveChanges();
        }



    }
}
