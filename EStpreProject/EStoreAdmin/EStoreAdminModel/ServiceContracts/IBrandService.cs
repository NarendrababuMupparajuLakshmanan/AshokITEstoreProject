using EStoreAdminModel.Models;

namespace EStoreAdminModel.ServiceContracts
{
    public interface IBrandService
    {
        List<BrandModel> ListBrands();

        void CreateBrand(CreateBrandModel createBrandModel);

        UpdateBrandModel GetBrandById(Guid id);

        void UpdateBrand(UpdateBrandModel updateBrandModel);
    }
}
