using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ActivitiyUserManager : IActivityUserService
    {
        private readonly IActivityUserDal _activityUserDal;


        public ActivitiyUserManager(IActivityUserDal activityUserService)
        {
            _activityUserDal = activityUserService;
        }
        public void Add(ActivityUser t)
        {
           _activityUserDal.Insert(t);
        }

        public ActivityUser CreateActivityUser(int activityId, int userId)
        {
            return new ActivityUser { ActivityID = activityId, UserID = userId };   
        }

        public void Delete(ActivityUser t)
        {
            throw new NotImplementedException();
        }

        public ActivityUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ActivityUser> GetList()
        {
            throw new NotImplementedException();
        }

        public List<ActivityUser> GetListById()
        {
            throw new NotImplementedException();
        }

        public void JoinActivity(ActivityUser activityUser)
        {
            _activityUserDal.Insert(activityUser);
        }

        public void Update(ActivityUser t)
        {
            throw new NotImplementedException();
        }
    }
}
