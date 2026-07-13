using EStoreAdminModel.Models.Types;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;
using EStoreAdminService.Exceptions;
using System.Reflection.Metadata;

namespace EStoreAdminService.Services
{
    public class TypeService : ITypeService
    {
        private readonly TypeRepository _typeRepository;

        public TypeService(TypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public void DeleteType(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new TypeIdNotNullException("Type Id is not valid");
            }

            TypeModel? typeModel = 
                this._typeRepository.Types.FirstOrDefault(t => t.Id == Id);

            if (typeModel == null)
            {
                throw new TypeNotNullException($"Type with Id {Id} not found");
            }

            this._typeRepository.Types.Remove(typeModel);
            this._typeRepository.SaveChanges();
        }

        public List<TypeModel> GetAllTypes()
        {
            List<TypeModel> typeModels =
                this._typeRepository.Types.ToList();

            return typeModels;
        }
    }
}
