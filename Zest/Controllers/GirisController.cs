using DataAccesssLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Zest.Models;

namespace Zest.Controllers
{
    [AllowAnonymous]

    public class GirisController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public GirisController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
           
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Login"); 
                }
            }
            return View(p);
        }


    }
}

















//[HttpPost]  
//public async Task<IActionResult> Index(Yazar y)
//{
//    Context c = new Context();
//    var datavalue=c.Yazars.FirstOrDefault(x => x.YazarMail == y.YazarMail &&
//    x.YazarSifre == y.YazarSifre);

//    if (datavalue != null)
//    {
//        var claims = new List<Claim>
//        {
//            new Claim(ClaimTypes.Name,y.YazarMail)
//        };
//        var useridentity = new ClaimsIdentity(claims, "a");
//        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
//        await HttpContext.SignInAsync(principal);

//        return RedirectToAction("Index","Dashboard");
//    }
//    else
//    {
//        return View();
//    }
//}


//Context c = new Context();
//var datavalue = c.Yazars.FirstOrDefault(x => x.YazarMail == y.YazarMail &&
//  x.YazarSifre == y.YazarSifre);
//if (datavalue != null)
//{
//    HttpContext.Session.SetString("usurname", y.YazarMail);
//    return RedirectToAction("Index", "Yazar");
//}
//else
//{
//    return View();
//}