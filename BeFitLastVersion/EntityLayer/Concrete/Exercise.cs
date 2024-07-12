using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Exercise
    {
        [Key]
        public int ExerciseID { get; set; }
        public string? ExerciseName { get; set; }
        public string? ExerciseDescription { get; set; }
        public int ExerciseCategory { get; set; }
        public bool ExerciseIsActive { get; set; }
        public string? ExerciseVideo { get; set; }
        public ICollection<ExerciseExerciseProgram> ExerciseExercisePrograms { get; set; }


    }
}
