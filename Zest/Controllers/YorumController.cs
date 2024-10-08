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
    public class YorumController : Controller
    {
        YorumManager ym = new YorumManager(new EfYorumRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialYorumEkle()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialYorumEkle(Yorum y)
        {
            y.YorumTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            y.YorumDurum = true;
            y.BlogID = 1;
            ym.YorumEkle(y);
            return PartialView();
        }
        public PartialViewResult BlogYorumList(int id)
        {
            var values=ym.ListYorumGetir(id);
            return PartialView(values);
        }
    }
}
