using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Day
    {
        public int DayID { get; set; }
        public string DayName { get; set; }
        public int WeekID { get; set; }
        public string? Exercise1 { get; set; }
        public string? Exercise2 { get; set; }
        public string? Exercise3 { get; set; }
        public string? Exercise4 { get; set; }
        public string? Exercise5 { get; set; }
        public string? Exercise6 { get; set; }
        public string? Exercise7 { get; set; }

        public Week? Week { get; set; }
    }
}
