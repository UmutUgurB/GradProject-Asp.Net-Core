using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserExercisePlanManager : IUserExercisePlanService
    {
        private readonly IExerciseUserDal _exerciseUserDal;


        public UserExercisePlanManager(IExerciseUserDal exerciseUserService)
        {
            _exerciseUserDal = exerciseUserService;
        }

        public void Add(UserExerciseProgram t)
        {
            throw new NotImplementedException();
        }

        public UserExerciseProgram CreateExercisePlanUser(int exerciseProgramId, int userId)
        {
            return new UserExerciseProgram { ExerciseProgramId = exerciseProgramId, UserID = userId };
        }

        public void Delete(UserExerciseProgram t)
        {
            throw new NotImplementedException();
        }

        public UserExerciseProgram GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserExerciseProgram> GetList()
        {
            throw new NotImplementedException();
        }

        public List<UserExerciseProgram> GetListById()
        {
            throw new NotImplementedException();
        }

        public void JoinExercisePlan(UserExerciseProgram userExerciseProgram)
        {
            _exerciseUserDal.Insert(userExerciseProgram);
        }

        public void Update(UserExerciseProgram t)
        {
            throw new NotImplementedException();
        }
    }
}
