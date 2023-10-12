using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CarBookContext _ctx;
        public GenericRepository(/*CarBookContext ctx*/)
        {
            //_ctx = ctx;
            _ctx = new CarBookContext();
        }
        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            _ctx.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _ctx.Set<T>().Add(entity);
            _ctx.SaveChanges();
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
            _ctx.SaveChanges();
        }
    }
}
