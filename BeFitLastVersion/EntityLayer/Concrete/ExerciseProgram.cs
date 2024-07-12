namespace EntityLayer.Concrete
{
    public class ExerciseProgram
    {
        public int ExerciseProgramId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public List<Week> Weeks { get; set; }

        public virtual ICollection<UserExerciseProgram>? UserExercisePrograms { get; set; }
        public ICollection<ExerciseExerciseProgram>? ExerciseExercisePrograms { get; set; }

    }
}
