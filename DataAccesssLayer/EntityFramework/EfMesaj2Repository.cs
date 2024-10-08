using DataAccesssLayer.Abstract;
using DataAccesssLayer.Concrete;
using DataAccesssLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.EntityFramework
{
    public class EfMesaj2Repository : GenericRepository<Mesaj2>, IMesaj2Dal
    {
        public List<Mesaj2> YazaraGoreMesajİleListeyiGetir(int id)
        {
            using (var c = new Context())
            {
                return c.Mesaj2s.Include(x => x.GonderenKullanici ).Where(x => x.MesajGonderenID == id).ToList();
            }
        }
    }
}
