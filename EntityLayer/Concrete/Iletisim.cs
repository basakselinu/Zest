﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        public string IletisimKullanıcıAd { get; set; }
        public string IletisimMail { get; set; }
        public string IletisimBaslık { get; set; }
        public string IletisimIcerik { get; set; }
        public DateTime IletisimTarih { get; set; }
        public bool IletisimDurum { get; set; }
    }
}
