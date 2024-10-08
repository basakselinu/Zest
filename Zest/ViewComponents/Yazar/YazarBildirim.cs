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

    public class YazarBildirim : ViewComponent
    {
        BildirimManager bm = new BildirimManager(new EfBildirimRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.ListTGetir();
            return View(values);
        }
    }
}