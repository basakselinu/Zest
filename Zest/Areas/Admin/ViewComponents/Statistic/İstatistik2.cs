using DataAccesssLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Areas.Admin.ViewComponents.Statistic
{
    public class İstatistik2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogBaslik).Take(1).FirstOrDefault();
            ViewBag.v2 = c.Iletisims.Count();
            ViewBag.v3 = c.Yorums.Count();
            return View();
        }
    }
}
