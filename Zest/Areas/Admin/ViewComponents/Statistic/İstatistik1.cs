using BusinessLayer.Concrete;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zest.Areas.Admin.ViewComponents.Statistic
{
    public class İstatistik1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.ListTGetir().Count();
            ViewBag.v2 = c.Iletisims.Count();
            ViewBag.v3 = c.Yorums.Count();

            string api = "069bbea9a7b676ea17187315db72b82d";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=konya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
