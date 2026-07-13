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
    }
}
