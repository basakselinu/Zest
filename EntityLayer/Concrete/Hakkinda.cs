using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkinda
    {
        [Key]
        public int HakkindaID { get; set; }
        public string HakkindaDetay1 { get; set; }
        public string HakkindaDetay2 { get; set; }
        public string HakkindaResim1 { get; set; }
        public string HakkindaResim2 { get; set; }
        public string HakkindaHarita { get; set; }
        public bool HakkindaDurum { get; set; }
        
    }
}
