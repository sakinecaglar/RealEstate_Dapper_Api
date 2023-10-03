using Microsoft.AspNetCore.Mvc;

namespace RealEstate_DapperUI.ViewComponents.HomePage
{
    public class _DefaultBottomGridComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
