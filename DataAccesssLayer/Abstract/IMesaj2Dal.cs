using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.Abstract
{
    public interface IMesaj2Dal  :IGenericDal<Mesaj2>
    {
        List<Mesaj2> YazaraGoreMesajİleListeyiGetir(int id);
    }
}
