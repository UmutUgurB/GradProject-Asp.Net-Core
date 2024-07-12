
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IActivityService : IGenericService<Activity>
    {
        List<Activity> GetActivityById(int id);
        void Add(Activity activity);
        void JoinActivity(ActivityUser activityUser);
        public List<Activity> GetActivitiesByUser(int id);
        public Activity GetParticipantsById(int id);
        void DeleteByFounder(int activityId, int founderId);
    }
}
