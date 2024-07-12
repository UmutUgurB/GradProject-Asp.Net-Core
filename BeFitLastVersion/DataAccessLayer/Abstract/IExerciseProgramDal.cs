using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IExerciseProgramDal : IGenericDal<ExerciseProgram>
    {
        List<ExerciseProgram> GetExerciseProgramsByUserId(int userId);
    }
}
