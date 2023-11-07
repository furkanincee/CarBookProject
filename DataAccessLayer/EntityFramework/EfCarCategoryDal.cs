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
    public class EfCarCategoryDal : GenericRepository<CarCategory>, ICarCategoryDal
    {
        public Dictionary<string, int> GetCategoriesWithCarCount()
        {
            var categoryCounts = _ctx.CarCategories
                        .Select(category => new
                        {
                            CategoryName = category.CategoryName,
                            CarCount = _ctx.Cars.Count(car => car.CarCategoryId == category.CarCategoryId)
                        }).ToList();

            return new Dictionary<string, int>();
        }

    }
}
