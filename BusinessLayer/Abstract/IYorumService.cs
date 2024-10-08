using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumService
    {
        List<Yorum> ListYorumGetir(int id);
        void YorumEkle(Yorum yorum);
        //void YorumSil(Yorum yorum);
       //void YorumGuncelle(Yorum yorum);
        //Yorum IDGoreGetir(int id);
    }
}
