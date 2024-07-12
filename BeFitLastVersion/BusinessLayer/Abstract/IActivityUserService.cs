using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IActivityUserService : IGenericService<ActivityUser>
    {
        public void JoinActivity(ActivityUser activityUser);
        public ActivityUser CreateActivityUser(int activityId, int userId);
    }
}
