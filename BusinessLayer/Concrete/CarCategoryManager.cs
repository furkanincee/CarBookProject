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
    public class CarCategoryManager : ICarCategoryService
    {
        private readonly ICarCategoryDal _carCategoryDal;

        public CarCategoryManager(ICarCategoryDal carCategoryDal)
        {
            _carCategoryDal = carCategoryDal;
        }
        public void Delete(CarCategory entity)
        {
            _carCategoryDal.Delete(entity);
        }

        public CarCategory GetbyId(int id)
        {
            return _carCategoryDal.GetById(id);
        }

        public List<CarCategory> GetListAll()
        {
            return _carCategoryDal.GetAll();
        }

        public void Insert(CarCategory entity)
        {
            _carCategoryDal.Insert(entity); 
        }

        public void Update(CarCategory entity)
        {
            _carCategoryDal.Update(entity);
        }

        public void GetCategoriesWithCarCount()
        {
            _carCategoryDal.GetCategoriesWithCarCount();
        }
    }
}
