using EStoreAdminModel.Models.Types;
using EStoreAdminModel.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Controllers
{
    public class TypeController : Controller
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult ListTypes()
        {
            List<TypeModel> typeModels = this._typeService.GetAllTypes();

            return View(typeModels);
        }

        [HttpGet]
        [Route("DeleteType")]
        public IActionResult DeleteType(Guid Id)
        {
            //call the TypeService to delete the type
            this._typeService.DeleteType(Id);

            return RedirectToAction("ListTypes");
        }

        [HttpGet]
        [Route("CreateType")]
        public ActionResult CreateType()
        {
            CreateTypeModel createTypeModel = new CreateTypeModel();
            return View(createTypeModel);
        }

        [HttpPost]
        [Route("CreateType")]
        public ActionResult CreateType(CreateTypeModel createTypeModel)
        {
            //Implement Logic on Create Type Model to DB
            this._typeService.CreateType(createTypeModel);

            return RedirectToAction("ListTypes");
        }

        [HttpGet]
        [Route("EditType/{Id:guid}")]
        public ActionResult EditType(Guid Id)
        {

            //Call the update data of Type Model
            UpdateTypeModel updateTypeModel =
                this._typeService.GetTypeById(Id);

            return View(updateTypeModel);
        }

        [HttpPost]
        [Route("EditType/{Id:guid}")]
        public ActionResult EditType(UpdateTypeModel updateTypeModel, Guid id)
        {

            //update the Model into db
            this._typeService.UpdateType(updateTypeModel);

            return RedirectToAction("ListTypes");
        }
    }
}
