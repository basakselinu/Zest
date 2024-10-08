using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesaj2
    {
        [Key]
        public int MesajID { get; set; }
        public int? MesajGonderenID { get; set; }
        public int? MesajAlanID { get; set; }
        public string MesajKonusu { get; set; }
        public string MesajDetay { get; set; }
        public DateTime MesajTarih { get; set; }
        public bool MesajDurum { get; set; }
        public Yazar GonderenKullanici { get; set; }
        public Yazar AlanKullanici { get; set; }
    }
}
