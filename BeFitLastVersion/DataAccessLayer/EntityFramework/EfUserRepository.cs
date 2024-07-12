using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
        public User GetUserWithActivities(int userId)
        {
            using (var context = new Context())
            {
                return context.Users
                    .Include(u => u.ActivityUsers)
                    .ThenInclude(au => au.Activity)
                    .FirstOrDefault(u => u.UserID == userId);
            }
        }

        public User GetUserWithExercisePrograms(int userId)
        {
            using (var context = new Context())
            {
                return context.Users
                    .Include(u => u.UserExercisePrograms)
                    .ThenInclude(uep => uep.ExerciseProgram)
                    .FirstOrDefault(u => u.UserID == userId);
            }
        }
    }
}
