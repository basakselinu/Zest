using BusinessLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.ViewComponents.Yorum
{
    public class BlogaGoreYorum : ViewComponent
    {
        YorumManager ym = new YorumManager(new EfYorumRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = ym.ListYorumGetir(id);
            return View(values);
        }
    }
}
