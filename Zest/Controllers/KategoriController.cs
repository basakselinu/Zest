using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager km = new KategoriManager(new EfKategoriRepository());
        public IActionResult Index()
        {
            var values = km.ListKategoriGetir();
            return View(values);
        }
    }
}
