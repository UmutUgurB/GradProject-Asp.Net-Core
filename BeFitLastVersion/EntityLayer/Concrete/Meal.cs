using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Meal
    {
        public int MealID { get; set; }
        public string? MealName { get; set;}
        public string? MealDescription { get; set;}
        public int MealCalory { get; set;}  
        public int MealProtein { get; set;}
        public int MealCarb {  get; set;}   
        public int MealFat { get; set;}
        
    }
}
