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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void Delete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public Service GetbyId(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetAll();
        }

        public void Insert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void Update(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
