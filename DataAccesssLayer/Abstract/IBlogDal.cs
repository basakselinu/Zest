using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> KategoriİleListeyiGetir();
        List<Blog> YazaraGoreKategoriİleListeyiGetir(int id);
    }
}
