using EStoreAdminModel.Models.Types;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminRepository.Repository;
using EStoreAdminService.Exceptions;

namespace EStoreAdminService.Services
{
    public class TypeService : ITypeService
    {
        private readonly TypeRepository _typeRepository;

        public TypeService(TypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public void CreateType(CreateTypeModel createTypeModel)
        {
            if (createTypeModel == null) 
            {
                throw new TypeNotNullException("Type Model is not null");
            }

            TypeModel typeModel = new TypeModel()
            {
                Id = Guid.NewGuid(),
                Name = createTypeModel.Name
            };

            this._typeRepository.Types.Add(typeModel);
            this._typeRepository.SaveChanges();
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

        public UpdateTypeModel GetTypeById(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new TypeIdNotNullException("Type Id is not null or empty");
            }

            TypeModel? typeModel =
                this._typeRepository.Types.Where(id =>  id.Id == Id).FirstOrDefault();

            if (typeModel == null)
                throw new TypeNotNullException("Type Model is null");

            UpdateTypeModel updateTypeModel = new UpdateTypeModel()
            {
                Id = typeModel.Id,
                Name = typeModel.Name,
            };

            return updateTypeModel;
        }

        public void UpdateType(UpdateTypeModel updateTypeModel)
        {
            if (updateTypeModel == null)
                throw new TypeNotNullException("Update Type Model is null");

            TypeModel typeModel = new TypeModel()
            {
                Id = updateTypeModel.Id,
                Name = updateTypeModel.Name,
            };

            this._typeRepository.Types.Update(typeModel);
            this._typeRepository.SaveChanges();
        }
    }
}
