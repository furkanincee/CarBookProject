using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
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
    public class EfPriceDal : GenericRepository<Price>, IPriceDal
    {

        public List<Price> GetPricesWithCars()
        {
            var ctx = new CarBookContext();
            return ctx.Prices.Include(x => x.Car).ThenInclude(y=>y.Brand).ToList(); // Eğer carın statusunu de getirecek olsaydık devamında .Include(x=>x.Car).ThenInclude(x=>x.CarStatus) dememiz gerekecekti yani yeniden Carı include etmemiz gerekecekti
        }
    }
}
