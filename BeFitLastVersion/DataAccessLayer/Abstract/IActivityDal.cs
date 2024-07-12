

using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DataAccessLayer.Abstract
{
    public interface IActivityDal : IGenericDal<Activity>
    {
        Activity GetActivityWithUsers(int id);
    }
}
