using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    public class IletisimController : Controller
    {
        IletisimManager im = new IletisimManager(new EfIletisimRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Iletisim i)
        {
            i.IletisimTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            i.IletisimDurum = true;
            im.IletisimEkle(i);
            return RedirectToAction("Index","Blog");
        }
    }
}
