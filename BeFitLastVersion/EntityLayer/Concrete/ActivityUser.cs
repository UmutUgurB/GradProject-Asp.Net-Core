using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ActivityUser
    {
        public int ActivityID { get; set; }
        public Activity Activity { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
