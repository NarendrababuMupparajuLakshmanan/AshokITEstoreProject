using EStoreAdminModel.Models.Types;

namespace EStoreAdminModel.ServiceContracts
{
    public interface ITypeService
    {

        List<TypeModel> GetAllTypes();

        void DeleteType(Guid Id);
    }
}
