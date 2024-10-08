using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zest.Models
{
    public class ProfilResmiEkle
    { 
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarBilgi { get; set; }
        public IFormFile YazarResim { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public bool YazarDurum { get; set; }
    }
}
