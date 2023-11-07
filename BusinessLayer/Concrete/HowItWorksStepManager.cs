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
    public class HowItWorksStepManager : IHowItWorksStepService
    {
        private readonly IHowItWorksStepDal _howItWorksStepDal;
        public HowItWorksStepManager(IHowItWorksStepDal howItWorksStepDal)
        {
            _howItWorksStepDal = howItWorksStepDal;
        }
        public void Delete(HowItWorksStep entity)
        {
            _howItWorksStepDal.Delete(entity);
        }

        public HowItWorksStep GetbyId(int id)
        {
            return _howItWorksStepDal.GetById(id);
        }

        public List<HowItWorksStep> GetListAll()
        {
            return _howItWorksStepDal.GetAll();
        }

        public void Insert(HowItWorksStep entity)
        {
            _howItWorksStepDal.Insert(entity);
        }

        public void Update(HowItWorksStep entity)
        {
            _howItWorksStepDal.Update(entity);
        }
    }
}
