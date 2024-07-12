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
    public class ExerciseManager : IExerciseService
    {
        private readonly IExerciseDal _exerciseDal;

        public ExerciseManager(IExerciseDal exerciseDal)
        {
            _exerciseDal = exerciseDal;
        }
        

        public void Add(Exercise t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Exercise t)
        {
            _exerciseDal.Delete(t);
        }

        public Exercise GetById(int id)
        {
            return _exerciseDal.GetByID(id);
        }

        

        public List<Exercise> GetList()
        {
            return _exerciseDal.GetListAll();
        }

        public List<Exercise> GetListById()
        {
            throw new NotImplementedException();
        }

        public void Update(Exercise t)
        {
            throw new NotImplementedException();
        }
    }
}
