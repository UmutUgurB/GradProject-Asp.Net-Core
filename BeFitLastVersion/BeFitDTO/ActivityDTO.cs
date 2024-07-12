using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitDTO
{
    public class ActivityDTO
    {
        public int ActivityID { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityFounder { get; set; }
        public List<UserDTO>? Users { get; set; }
    }
}
