using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
