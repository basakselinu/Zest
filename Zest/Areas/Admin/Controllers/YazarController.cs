using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zest.Areas.Admin.Models;

namespace Zest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YazarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult YazarListesi()
        {
            var jsonYazars = JsonConvert.SerializeObject(yazars);
            return Json(jsonYazars);
        }

        public IActionResult IDGoreYazarListesiGetir(int xid)
        {
            var yazaribul = yazars.FirstOrDefault(x => x.YazarID == xid);
            var jsonYazars = JsonConvert.SerializeObject(yazaribul);
            return Json(jsonYazars);
        }

        [HttpPost]
        public IActionResult YazarEkle(YazarModel w)
        {
            yazars.Add(w);
            var jsonYazars = JsonConvert.SerializeObject(w);
            return Json(jsonYazars);
        }
    
        public IActionResult YazarSil(int id)
        {
            var yazar = yazars.FirstOrDefault(x => x.YazarID == id);
            yazars.Remove(yazar);       
            return Json(yazar);
        }

        public IActionResult YazarGüncelle(YazarModel w)
        {
            var yazar = yazars.FirstOrDefault(x => x.YazarID ==w.YazarID);
            yazar.YazarAdi = w.YazarAdi;
            var jsonYazar= JsonConvert.SerializeObject(w);
            return Json(jsonYazar);
        }

        public static List<YazarModel> yazars = new List<YazarModel>
        {
            new YazarModel
            {
                YazarID=1,
                YazarAdi="Fidan"
            },
            new YazarModel
            {
                YazarID=2,
                YazarAdi="Hüsnü"
            },
            new YazarModel
            {
                YazarID=3,
                YazarAdi="Bergün"
            }
        };
    }
}
