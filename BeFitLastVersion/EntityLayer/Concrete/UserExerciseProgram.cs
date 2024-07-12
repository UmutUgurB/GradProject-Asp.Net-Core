using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserExerciseProgram
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int ExerciseProgramId { get; set; }
        public ExerciseProgram ExerciseProgram { get; set; }    
    }
}
