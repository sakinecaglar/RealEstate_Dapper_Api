using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
