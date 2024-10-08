using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminKullanıcıAd { get; set; }
        public string AdminSifre { get; set; }
        public string AdminAdı { get; set; }
        public string AdminAcıklamakısa { get; set; }
        public string AdminResimURL { get; set; }
        public string Rol { get; set; }
    }
}
