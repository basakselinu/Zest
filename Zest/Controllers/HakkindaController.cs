using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    public class HakkindaController : Controller
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkindaRepository());
        public IActionResult Index()
        {
            var values = hm.ListHakkindaGetir();
            return View(values);
        }
        public PartialViewResult SosyalMedya()
        {
            
            return PartialView();
        }
    }
}
