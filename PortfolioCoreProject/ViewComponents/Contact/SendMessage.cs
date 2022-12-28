using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreProject.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
