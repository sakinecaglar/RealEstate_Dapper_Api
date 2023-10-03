using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
