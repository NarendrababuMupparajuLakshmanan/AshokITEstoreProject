using EStoreAdminModel.Models.Types;

namespace EStoreAdminModel.ServiceContracts
{
    public interface ITypeService
    {

        List<TypeModel> GetAllTypes();

        void DeleteType(Guid Id);

        void CreateType(CreateTypeModel createTypeModel);

        UpdateTypeModel GetTypeById(Guid Id);

        void UpdateType(UpdateTypeModel updateTypeModel);
    }
}
