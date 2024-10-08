using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesssLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Controllers
{
    public class KayıtController : Controller
    {
        YazarManager ym = new YazarManager(new EfYazarRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Yazar y)
        {
            YazarDogrulama kural = new YazarDogrulama();
            ValidationResult sonuc = kural.Validate(y);
            if (sonuc.IsValid)
            {
                y.YazarDurum = true;
                y.YazarBilgi = "deneme";
                ym.TEkle(y);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var c in sonuc.Errors)
                {
                    ModelState.AddModelError(c.PropertyName, c.ErrorMessage);
                }
            }
            return View();
        }
    }
}
