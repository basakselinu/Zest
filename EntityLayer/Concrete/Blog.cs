using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string Blogİcerik { get; set; }
        public string BlogKapakResim { get; set; }
        public string BlogResim { get; set; }
        public DateTime BlogTarih { get; set; }
        public bool BlogDurum { get; set; }
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public int YazarID { get; set; }
        public Yazar Yazar { get; set; }
        public List<Yorum> Yorums { get; set; }
    }
}
