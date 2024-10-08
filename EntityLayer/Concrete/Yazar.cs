using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarBilgi { get; set; }
        public string YazarResim { get; set; }
        public string YazarMail { get; set; }
        public string YazarSifre { get; set; }
        public bool YazarDurum { get; set; }
        public List<Blog> Blogs { get; set; }
        public virtual ICollection<Mesaj2> MesajGonderen { get; set; }
        public virtual ICollection<Mesaj2> MesajAlan { get; set; }
    }
}
