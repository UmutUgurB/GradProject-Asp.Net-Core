using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? UserEmail { get; set;}
        public string? UserPassword { get; set;} 
        public string? UserPhone { get; set;}
        public string? UserImage { get; set;}   
        public string? UserHeight { get; set; } 
        public string? UserWeight { get; set; } 
        public bool UserIsActive { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; } 

       
        public virtual ICollection<ActivityUser> ActivityUsers { get; set; }
        public virtual ICollection<UserExerciseProgram> UserExercisePrograms { get; set; }

    }
}
