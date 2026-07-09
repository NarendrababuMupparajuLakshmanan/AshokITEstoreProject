using EStoreAdminModel.Models;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IBrandService _brandService1;
        private readonly IBrandService _brandService2;

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

        public string About()
        {
            return "Welcome To About";
        }
    }
}
