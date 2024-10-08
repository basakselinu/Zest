using DataAccesssLayer.Abstract;
using DataAccesssLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesssLayer.EntityFramework
{
    class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
    }
}
