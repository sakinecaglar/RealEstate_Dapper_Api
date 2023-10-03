using Microsoft.AspNetCore.Mvc;

namespace RealEstate1_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
