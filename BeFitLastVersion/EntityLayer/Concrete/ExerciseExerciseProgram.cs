using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExerciseExerciseProgram
    {
        public int ExerciseExerciseProgramID { get; set; }

        public int ExerciseID { get; set; }
        public Exercise Exercise { get; set; }

        public int ExerciseProgramId { get; set; }
        public ExerciseProgram ExerciseProgram { get; set; }
    }
}
