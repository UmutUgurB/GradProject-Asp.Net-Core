using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        User GetUserWithActivities(int userId);
        User GetUserWithExercisePrograms(int userId);
    }
}
