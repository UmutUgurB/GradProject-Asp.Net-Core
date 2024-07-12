using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Service : IGenericService<Message2>
    {
        List<Message2> GetListByUser(int id);
        Task SendMessage(Message2 message);
    }
}
