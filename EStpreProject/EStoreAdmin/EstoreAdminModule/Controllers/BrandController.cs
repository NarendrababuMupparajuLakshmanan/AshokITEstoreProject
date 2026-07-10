using EStoreAdminModel.Models;
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

        [Route("/")]
        public ActionResult Index()
        {
            // BrandService brandService = new BrandService();

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
      
    }
}
