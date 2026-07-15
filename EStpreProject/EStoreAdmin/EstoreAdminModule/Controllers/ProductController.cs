using Microsoft.AspNetCore.Mvc;

namespace EstoreAdminModule.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult ListProduct()
        {
            return View();
        }
    }
}
