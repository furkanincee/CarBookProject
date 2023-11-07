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
    public class CarDetailManager : ICarDetailService
    {
        private readonly ICarDetailDal _carDetailDal;
        public CarDetailManager(ICarDetailDal carDetailDal)
        {
            _carDetailDal = carDetailDal;
        }
        public void Delete(CarDetail entity)
        {
            _carDetailDal.Delete(entity);
        }

        public CarDetail GetbyId(int id)
        {
           return _carDetailDal.GetById(id);
        }

        public List<CarDetail> GetListAll()
        {
            return _carDetailDal.GetAll();
        }

        public void Insert(CarDetail entity)
        {
            _carDetailDal.Insert(entity);
        }

        public CarDetail GetCarDetailByCarId(int id)
        {
            return _carDetailDal.GetCarDetailByCarId(id);
        }

        public void Update(CarDetail entity)
        {
            _carDetailDal.Update(entity);
        }
    }
}
