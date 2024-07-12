using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IExercisePlanService :  IGenericService<ExerciseProgram>
    {
        List<Exercise> GetExercisesByProgramId(int programId);
        List<ExerciseProgram> GetExerciseProgramsByUserId(int userId);
        
    }
}
