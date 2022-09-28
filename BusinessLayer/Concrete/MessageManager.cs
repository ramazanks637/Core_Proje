using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message Entity)
        {
            _messageDal.Insert(Entity);
        }

        public void Delete(Message Entity)
        {
            _messageDal.Delete(Entity);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

        public void Update(Message Entity)
        {
            _messageDal.Update(Entity);
        }
    }
}
