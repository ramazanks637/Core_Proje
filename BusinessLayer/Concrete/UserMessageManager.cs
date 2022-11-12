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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void Add(UserMessages Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserMessages Entity)
        {
            throw new NotImplementedException();
        }

        public UserMessages GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessages> GetList()
        {
           return _userMessageDal.GetList();
        }

        public List<UserMessages> GetUserMessagesWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void Update(UserMessages Entity)
        {
            throw new NotImplementedException();
        }
    }
}
