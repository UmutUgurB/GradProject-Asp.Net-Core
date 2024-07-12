using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userdal;

        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }

        public void Add(User t)
        {
            throw new NotImplementedException();
        }

        public void Delete(User t)
        {
            _userdal.Delete(t);
        }

        

        public List<User> GetList()
        {
            return _userdal.GetListAll();
        }

        public void Update(User t)
        {
            _userdal.Update(t);
        }

        public void UserAdd(User user)
        {
            _userdal.Insert(user);
        }

        public User GetById(int id)
        {
            return _userdal.GetByID(id);
        }

        public User GetUserWithActivities(int userId)
        {
            return _userdal.GetUserWithActivities(userId);
        }

        public List<User> GetListById()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
