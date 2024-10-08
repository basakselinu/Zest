using BusinessLayer.Concrete;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.ViewComponents.Yazar
{
    public class YazarHakkindaDashboard : ViewComponent
    {
        YazarManager ym = new YazarManager(new EfYazarRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {        
            var username = User.Identity.Name;
            ViewBag.veri = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var yazarID = c.Yazars.Where(x => x.YazarMail == usermail).Select(y => y.YazarID).FirstOrDefault();
            var values = ym.IDGoreYazarGetir(yazarID);
            return View(values);
        }
    }
}
