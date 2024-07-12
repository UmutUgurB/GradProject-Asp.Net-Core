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
    public class WeekManager : IWeekService
    {
        private readonly IWeekDal _weekdal;

        public WeekManager(IWeekDal weekDal)
        {
            _weekdal = weekDal;
        }
        public void Add(Week t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Week t)
        {
            throw new NotImplementedException();
        }

        public Week GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Week> GetList()
        {
            return _weekdal.GetListAll();   
        }

        public List<Week> GetListById()
        {
            throw new NotImplementedException();
        }

        public List<Week> GetListWeeksByExercisePlan(int exercisePlanId)
        {
            return _weekdal.GetListAll().Where(x => x.ExerciseProgramId == exercisePlanId).ToList();
        }

        public void Update(Week t)
        {
            throw new NotImplementedException();
        }
    }
}
