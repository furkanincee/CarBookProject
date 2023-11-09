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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment GetbyId(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentsByCar(int carId)
        {
            return _commentDal.GetCommentsByCar(carId);
        }

        public List<Comment> GetListAll()
        {
            return _commentDal.GetAll();
        }

        public void Insert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
