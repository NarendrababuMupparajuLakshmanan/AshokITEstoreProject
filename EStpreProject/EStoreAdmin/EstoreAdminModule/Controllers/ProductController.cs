using EStoreAdminModel.Models.Brands;
using EStoreAdminModel.Models.Products;
using EStoreAdminModel.Models.Types;
using EStoreAdminModel.ServiceContracts;
using EStoreAdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ITypeService _typeService;

        public ProductController(IProductService productService,
            IBrandService brandService,
            ITypeService typeService)
        {
            _productService = productService;
            _brandService = brandService;
            _typeService = typeService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult ListProduct()
        {
            List<ProductModel> productModels
                = this._productService.ListProducts();


            return View(productModels);
        }

        [HttpGet]
        [Route("CreateProduct")]
        public ActionResult CreateProduct()
        {
            CreateProductModel createProductModel = new CreateProductModel();

            List<BrandModel> brandModels
                = this._brandService.ListBrands();

            ViewBag.Brands = brandModels;

            List<TypeModel> typeModels
                = this._typeService.GetAllTypes();

            ViewBag.Types = typeModels;

            return View(createProductModel);
        }
    }
}
