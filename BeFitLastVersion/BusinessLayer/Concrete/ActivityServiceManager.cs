
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;



namespace BusinessLayer.Concrete
{
    public class ActivityServiceManager : IActivityService
    {
        private readonly IActivityDal _activityService; 
        private readonly IActivityUserDal _activityUserDal;

        public ActivityServiceManager(IActivityDal activityService)
        {
            _activityService = activityService;
        }

        public void Add(Activity activity)
        {
           
            _activityService.Insert(activity);
        }

        

        public void Delete(Activity t)
        {
            _activityService.Delete(t); 
        }

        

        public List<Activity> GetActivitiesByUser(int id)
        {
            return _activityService.GetListAll(x => x.FounderID == id);
        }

        public List<Activity> GetActivityById(int id)
        {
            return _activityService.GetListAll(x=>x.FounderID ==id);
        }

        public Activity GetById(int id)
        {
            return _activityService.GetByID(id);
        }

        public List<Activity> GetList()
        {
            return _activityService.GetListAll(); 
        }
        public ActivityUser CreateActivityUser(int activityId, int userId)
        {
            return new ActivityUser { ActivityID = activityId, UserID = userId };
        }
        public void JoinActivity(ActivityUser activityUser)
        {
            _activityUserDal.Insert(activityUser);
        }

        public void Update(Activity t)
        {
            throw new NotImplementedException();
        }

        public Activity GetParticipantsById(int id)
        {
            return _activityService.GetActivityWithUsers(id);
        }

        public void DeleteByFounder(int activityId, int founderId)
        {
            var activity = _activityService.GetByID(activityId);
            if (activity != null && activity.FounderID == founderId)
            {
                _activityService.Delete(activity);
            }
        }

        public List<Activity> GetListById()
        {
            throw new NotImplementedException();
        }
    }

}



