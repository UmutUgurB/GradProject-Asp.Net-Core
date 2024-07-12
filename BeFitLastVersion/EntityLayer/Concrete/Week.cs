using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Week
    {
        public int WeekID { get; set; }
        public string WeekName { get; set; }
        public int WeekCategories { get; set; }
        public string WeekDescription { get; set; }
        public string? WeekPhoto { get; set; }
        public List<Day> Days { get; set; }
        public int ExerciseProgramId { get; set; }
        public ExerciseProgram? ExerciseProgram{ get; set; }

    }
}
