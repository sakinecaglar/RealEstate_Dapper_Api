using Microsoft.AspNetCore.Mvc;

namespace RealEstate1_Dapper_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
