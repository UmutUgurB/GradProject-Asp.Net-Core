using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        void ContactAdd(Contact contact);
    }
}
