using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAllCarsWithBrands()
        {
            return _carDal.GetAllCarsWithBrands();
        }

        public Car GetbyId(int id)
        {
           return _carDal.GetById(id);
        }

        public List<Car> GetListAll()
        {
            return _carDal.GetAll();
        }

        public void Insert(Car entity)
        {
            if (entity.Year >= 2010 && entity.Prices.Count > 0 && entity.Km <= 500000)
            {
                _carDal.Insert(entity);
            }
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
