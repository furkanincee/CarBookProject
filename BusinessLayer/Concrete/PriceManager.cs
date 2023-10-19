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
    public class PriceManager : IPriceService
    {
        private readonly IPriceDal _priceDal;

        public PriceManager(IPriceDal priceDal) 
        { 
            _priceDal = priceDal;
        }

        public void Delete(Price entity)
        {
            _priceDal.Delete(entity);
        }

        public Price GetbyId(int id)
        {
            return _priceDal.GetById(id);
        }

        public List<Price> GetListAll()
        {
            return _priceDal.GetAll();
        }
        
        public List<Price> GetPricesWithCars()
        {
            return _priceDal.GetPricesWithCars();
        }

        public void Insert(Price entity)
        {
            _priceDal.Insert(entity);
        }

        public void Update(Price entity)
        {
            _priceDal.Update(entity);
        }
    }
}
