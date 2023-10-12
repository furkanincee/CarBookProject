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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public Brand GetbyId(int id)
        {
            return _brandDal.GetById(id);
        }

        public List<Brand> GetListAll()
        {
            return _brandDal.GetAll();
        }

        public void Insert(Brand entity)
        {
             _brandDal.Insert(entity);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
