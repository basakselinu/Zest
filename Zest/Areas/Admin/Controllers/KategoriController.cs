using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Zest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoriController : Controller
    {
        KategoriManager km = new KategoriManager(new EfKategoriRepository());
        public IActionResult Index(int page = 1)
        {
            var values = km.ListTGetir().ToPagedList(page, 5);
            return View(values);
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori p)
        {
            KategoriManager km = new KategoriManager(new EfKategoriRepository());
            KategoriDogrulama kv = new KategoriDogrulama();
            ValidationResult sonuc = kv.Validate(p);
            List<SelectListItem> degerler = (from x in km.ListTGetir()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategoriID.ToString(),

                                             }).ToList();

            if (sonuc.IsValid)
            {
                p.KategoriDurum = true;
                km.TEkle(p);
                return RedirectToAction("Index", "Kategori");
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
        public IActionResult KategoriSil(int id)
        {
            var value = km.IDGoreGetir(id);
            km.TSil(value);
            return RedirectToAction("Index");
        }
    }
}
