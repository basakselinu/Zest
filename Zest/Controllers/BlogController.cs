using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        KategoriManager km = new KategoriManager(new EfKategoriRepository());
        Context c = new Context();

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.KategoriİleListeyiGetir();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogHepsiniOku(int id)
        {
            ViewBag.i = id;
            var values = bm.IDGoreBlogGetir(id);
            return View(values);
        }
        public IActionResult YazaraGoreBlogListesi()
        {
            Context c = new Context(); 
            var kullanicimail = User.Identity.Name;
            var yazarID = c.Yazars.Where(x => x.YazarMail == kullanicimail).Select(y => y.YazarID).FirstOrDefault();
            var values = bm.YazaraGoreKategoriİleListeyiGetirBM(yazarID);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogEkle()
        {           
            List<SelectListItem> degerler = (from x in km.ListTGetir()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString(),

                                             }).ToList();
            ViewBag.deg = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult BlogEkle(Blog b)
        {
            
            var kullanicimail = User.Identity.Name;
            var yazarID = c.Yazars.Where(x => x.YazarMail == kullanicimail).
                Select(y => y.YazarID).FirstOrDefault();

            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            BlogDogrulama bv = new BlogDogrulama();
            ValidationResult sonuc = bv.Validate(b);
            List<SelectListItem> degerler = (from x in km.ListTGetir()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString(),

                                             }).ToList();
           
            if (sonuc.IsValid)
            {
                b.BlogDurum = true;
                b.BlogTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.YazarID = yazarID;
                bm.TEkle(b);
                return RedirectToAction("YazaraGoreBlogListesi", "Blog");
            }
            else
            {
                foreach (var c in sonuc.Errors)
                {
                    ModelState.AddModelError(c.PropertyName, c.ErrorMessage);
                }
                ViewBag.deg = degerler;
                return View();
            }
        }
        public IActionResult BlogSil(int id)
        {
            var blogdeg = bm.IDGoreGetir(id);
            bm.TSil(blogdeg);
            return RedirectToAction("YazaraGoreBlogListesi");
        }
        [HttpGet]
         public IActionResult BlogGuncelle(int id)
        {
            var blogdeg = bm.IDGoreGetir(id);
            List<SelectListItem> degerler = (from x in km.ListTGetir()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString(),

                                             }).ToList();
            ViewBag.deg = degerler;
            return View(blogdeg);
        }
        [HttpPost]
        public IActionResult BlogGuncelle(Blog b)
        {
            var kullanicimail = User.Identity.Name;
            var yazarID = c.Yazars.Where(x => x.YazarMail == kullanicimail).
                Select(y => y.YazarID).FirstOrDefault();

            var blogdeg = bm.IDGoreGetir(b.BlogID);
            b.YazarID = yazarID;
            b.BlogTarih = blogdeg.BlogTarih;
            b.BlogDurum = blogdeg.BlogDurum;
            bm.TGuncelle(b);
            return RedirectToAction("YazaraGoreBlogListesi","Blog");
        }
    }
}
