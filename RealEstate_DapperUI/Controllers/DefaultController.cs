using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
