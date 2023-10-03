using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
