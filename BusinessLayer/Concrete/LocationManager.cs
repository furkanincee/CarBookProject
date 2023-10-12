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
    public class LocationManager : ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal) 
        {
            _locationDal = locationDal;
        }

        public void Delete(Location entity)
        {
            _locationDal.Delete(entity);
        }

        public Location GetbyId(int id)
        {
            return _locationDal.GetById(id);
        }

        public List<Location> GetListAll()
        {
            return _locationDal.GetAll();
        }

        public void Insert(Location entity)
        {
            _locationDal.Insert(entity);
        }

        public void Update(Location entity)
        {
            _locationDal.Update(entity);
        }
    }
}
