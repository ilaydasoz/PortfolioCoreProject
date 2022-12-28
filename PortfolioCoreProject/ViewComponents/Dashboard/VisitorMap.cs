using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
