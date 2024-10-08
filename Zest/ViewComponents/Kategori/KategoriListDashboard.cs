using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.ViewComponents.Kategori
{
    public class KategoriListDashboard : ViewComponent
    {
        KategoriManager km = new KategoriManager(new EfKategoriRepository());
        public IViewComponentResult Invoke()
        {
            var values = km.ListKategoriGetir();
            return View(values);
        }
    }
}
