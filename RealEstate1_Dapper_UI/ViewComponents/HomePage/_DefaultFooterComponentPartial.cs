﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate1_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
