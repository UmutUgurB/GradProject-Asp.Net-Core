using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfActivityRepository : GenericRepository<Activity>, IActivityDal
    {
        public Activity GetActivityWithUsers(int id)
        {
            using (var context = new Context())
            {
                return context.Activities
                    .Include(a => a.ActivityUsers)
                    .ThenInclude(au => au.User)
                    .FirstOrDefault(a => a.ActivityID == id);
            }
        }
    }
}
