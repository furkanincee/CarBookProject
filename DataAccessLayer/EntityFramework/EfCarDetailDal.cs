using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    internal class EfCarDetailDal : GenericRepository<CarDetail>, ICarDetailDal
    {
        public CarDetail GetCarDetailByCarId(int id)
        {
           return _ctx.CarDetails.Where(x => x.CarId == id).FirstOrDefault();
        }
    }
}
