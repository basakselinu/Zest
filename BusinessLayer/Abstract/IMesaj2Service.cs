using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesaj2Service : IGenericService<Mesaj2>
    {
        List<Mesaj2> YazarİleInboxListeGetir(int id);
    }
}
