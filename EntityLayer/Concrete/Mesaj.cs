using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }
        public string MesajGonderen { get; set; }
        public string MesajAlan { get; set; }
        public string MesajKonusu { get; set; }
        public string MesajDetay { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajDurum { get; set; }
    }
}
