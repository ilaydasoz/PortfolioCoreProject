using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
