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
    public class CarStatusManager : ICarStatusService
    {
        private readonly ICarStatusDal _carStatusDal;

        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;  
        }

        public void Delete(CarStatus entity)
        {
            _carStatusDal.Delete(entity);
        }

        public CarStatus GetbyId(int id)
        {
            return _carStatusDal.GetById(id);
        }

        public List<CarStatus> GetListAll()
        {
            return _carStatusDal.GetAll();
        }

        public void Insert(CarStatus entity)
        {
            _carStatusDal.Insert(entity);
        }

        public void Update(CarStatus entity)
        {
            _carStatusDal.Update(entity);
        }
    }
}
