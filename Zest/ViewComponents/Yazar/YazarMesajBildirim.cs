using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.ViewComponents.Yazar
{
  
    public class YazarMesajBildirim : ViewComponent
    {
        Mesaj2Manager ym = new Mesaj2Manager(new EfMesaj2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = ym.YazarİleInboxListeGetir(id);
            return View(values);
        }
    }
}
