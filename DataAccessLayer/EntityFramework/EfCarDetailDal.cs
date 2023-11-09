using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
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

        public CarDetail GetCarDetailWithAuthor(int id)
        {
           return _ctx.CarDetails.Include(x => x.AppUser).Where(y => y.CarId == id).FirstOrDefault();
        }
    }
}
