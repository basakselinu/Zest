 using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    [AllowAnonymous]
    public class DuyurularController : Controller
    {
        DuyurularManager dm = new DuyurularManager(new EfDuyurularRepository());

        [HttpGet]
        public PartialViewResult MailKayit()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult MailKayit(Duyurular d)
        {
            d.MailDurum = true;
            dm.DuyurularEkle(d);
            return PartialView();
        }
    }
}
