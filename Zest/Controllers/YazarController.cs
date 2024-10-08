using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Zest.Models;

namespace Zest.Controllers
{
    public class YazarController : Controller
    {
        YazarManager ym = new YazarManager(new EfYazarRepository());
        [Authorize]
        public IActionResult Index()
        {
            var kullanicimail = User.Identity.Name;
            ViewBag.v = kullanicimail;
            Context c = new Context();
            var yazarad = c.Yazars.Where(x => x.YazarMail == kullanicimail).Select(y => y.YazarAd).FirstOrDefault();
            ViewBag.v2 = yazarad;
            return View();
        }
        public IActionResult YazarProfili()
        {
            return View();
        }

        public IActionResult YazarMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Yazarpanel()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult YazarNavbar()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult YazarBilgi()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult YazarProfilDuzenle()
        {
            Context c = new Context();

            var kullanicimail = User.Identity.Name;
            var yazarID = c.Yazars.Where(x => x.YazarMail == kullanicimail).Select(y => y.YazarID).FirstOrDefault();
            var yazarvalues = ym.IDGoreGetir(yazarID);
            return View(yazarvalues);
        }
        
        [HttpPost]
        public IActionResult YazarProfilDuzenle(Yazar y)
        {
            YazarDogrulama yd = new YazarDogrulama();
            ValidationResult sonuc = yd.Validate(y);
            var pas1 = Request.Form["pass1"];
            var pas2 = Request.Form["pass2"];
            if (pas1 == pas2)
            {
                y.YazarSifre = pas2;
                ValidationResult result = yd.Validate(y);
                if (sonuc.IsValid)
                {
                    ym.TGuncelle(y);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var c in sonuc.Errors)
                    {
                        ModelState.AddModelError(c.PropertyName, c.ErrorMessage);
                    }
                }
            }
            else
            {
                ViewBag.hata = "Girdiğiniz Parolalar Uyuşmuyor!";
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult YazarEkle()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult YazarEkle(ProfilResmiEkle p)
        {
            Yazar y = new Yazar();
            if (p.YazarResim != null)
            {
                var uzantı = Path.GetExtension(p.YazarResim.FileName);
                var yeniresimismi = Guid.NewGuid() + uzantı;
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/YazarResimdosyasi/", yeniresimismi);
                var stream = new FileStream(konum, FileMode.Create);
                p.YazarResim.CopyTo(stream);
                y.YazarResim = yeniresimismi;
            }
            y.YazarMail = p.YazarMail;
            y.YazarAd = p.YazarAd;
            y.YazarSifre = p.YazarSifre;
            y.YazarDurum = true;
            y.YazarBilgi = p.YazarBilgi;
            ym.TEkle(y);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
