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
   
    public class BildirimController : Controller
    {
        BildirimManager bm = new BildirimManager(new EfBildirimRepository());
        public IActionResult Index()
        {  
            return View ();
        }
        [AllowAnonymous]
        public IActionResult TumBildirimler()
        {
            var values = bm.ListTGetir();
            return View (values);
        }


    }
}
