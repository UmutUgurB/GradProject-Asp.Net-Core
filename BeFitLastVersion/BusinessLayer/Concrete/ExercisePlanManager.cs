using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ExercisePlanManager : IExercisePlanService
    {
        private readonly IExerciseProgramDal _exerciseProgramDal;
        private readonly IUserDal _userdal;
        private readonly IWeekDal _weekDal;
        public ExercisePlanManager(IExerciseProgramDal exerciseProgramDal)
        {
            _exerciseProgramDal = exerciseProgramDal;
           
        }
        public void Add(ExerciseProgram t)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExerciseProgram t)
        {
            throw new NotImplementedException();
        }

        public ExerciseProgram GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ExerciseProgram> GetExerciseProgramsByUserId(int userId)
        {
            return _exerciseProgramDal.GetExerciseProgramsByUserId(userId);
        }

        public List<Exercise> GetExercisesByProgramId(int programId)
        {
            throw new NotImplementedException();
        }

        public List<ExerciseProgram> GetList()
        {
            return _exerciseProgramDal.GetListAll();
        }

        public List<ExerciseProgram> GetListById()
        {
            throw new NotImplementedException();
        }

        

        public void JoinExerciseProgram(int userId, int exerciseProgramId)
        {
            
           
        }

        public void Update(ExerciseProgram t)
        {
            throw new NotImplementedException();
        }
    }
}
