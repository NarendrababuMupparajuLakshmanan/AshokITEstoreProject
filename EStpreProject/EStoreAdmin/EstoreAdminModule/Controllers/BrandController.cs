using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        //Dependency Injection of BrandService Object
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [Route("ListBrand")]
        public ActionResult Index()
        {
            List<BrandModel> brandModels = this._brandService.ListBrands();

            return View(brandModels);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            CreateBrandModel createBrandModel = new CreateBrandModel();

            //ViewModel Binding to View data in the User Interface
            return View(createBrandModel);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CreateBrandModel createBrandModel)
        {

            this._brandService.CreateBrand(createBrandModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("EditBrand/{Id:guid}")]
        public IActionResult EditBrand(Guid Id)
        {

            UpdateBrandModel updateBrandModel
                = this._brandService.GetBrandById(Id);

           return View(updateBrandModel);
        }

        //In update, post and send id as url, we are posting a model and retrieve the Route Paramters {id:Guid}
        [HttpPost]
        [Route("EditBrand/{Id:guid}")]
        public IActionResult EditBrand(UpdateBrandModel updateBrandModel, Guid Id)
        {
            this._brandService.UpdateBrand(updateBrandModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("DeleteBrand/{Id:guid}")]
        public IActionResult DeleteBrand(Guid Id)
        {
            //Implement Delete Brand Logic
            this._brandService.DeleteBrand(Id);

            return RedirectToAction("Index");
        }
      
    }
}
