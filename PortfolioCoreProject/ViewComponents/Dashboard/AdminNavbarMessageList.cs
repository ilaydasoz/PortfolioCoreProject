using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
