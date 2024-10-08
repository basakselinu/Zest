using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zest.Areas.Admin.Models;

namespace Zest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KategoriChart()
        {
            List<KategoriModel> list = new List<KategoriModel>();

            list.Add(new KategoriModel
            {
                kategoriadi = "Aperatifler",
                kategoricount = 10
            });

            list.Add(new KategoriModel
            {
                kategoriadi = "Kahvaltılıklar",
                kategoricount = 20
            });

            list.Add(new KategoriModel
            {
                kategoriadi = "Sağlıklı Yaşam",
                kategoricount = 15
            });

            return Json(new { jsonlist = list });
        }
    }
}
