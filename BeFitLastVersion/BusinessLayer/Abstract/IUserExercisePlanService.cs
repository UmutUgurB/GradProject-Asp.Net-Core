using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserExercisePlanService : IGenericService<UserExerciseProgram>
    {
        public void JoinExercisePlan(UserExerciseProgram userExerciseProgram);
        public UserExerciseProgram CreateExercisePlanUser(int exerciseProgramId, int userId);
    }
}
