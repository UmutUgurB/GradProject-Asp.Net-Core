using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        private readonly IMessage2Dal _message2Dal;

        

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }
        public void Add(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetByID(id);    
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public List<Message2> GetListById()
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetListByUser(int id)
        {
            return _message2Dal.GetListMessageByWriter(id);
        }

        public Task SendMessage(Message2 message)
        {
            throw new NotImplementedException();
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
