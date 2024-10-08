using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zest.Models;

namespace Zest.ViewComponents
{
    public class YorumListe: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<KullanıcıYorumu>
            {
                new KullanıcıYorumu
                {
                    ID=1,
                    KullanıcıAdı="ahmet"

                },
                new KullanıcıYorumu
                {
                    ID=2,
                    KullanıcıAdı="ayşe"

                }
            };
            return View(values);
        }
    }
}
