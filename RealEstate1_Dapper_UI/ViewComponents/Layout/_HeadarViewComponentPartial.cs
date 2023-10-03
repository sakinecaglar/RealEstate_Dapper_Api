using Microsoft.AspNetCore.Mvc;

namespace RealEstate1_Dapper_UI.ViewComponents.Layout
{
    public class _HeadarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
