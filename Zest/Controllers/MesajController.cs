using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    [AllowAnonymous]
    public class MesajController : Controller
    {
        Mesaj2Manager mm = new Mesaj2Manager(new EfMesaj2Repository());
        public IActionResult GelenKutusu()
        {
            int id = 1;
            var values = mm.YazarİleInboxListeGetir(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult MesajDetayları(int id)
        {
            var mesajdeg = mm.IDGoreGetir(id);
            return View(mesajdeg);
        }
    }
}
