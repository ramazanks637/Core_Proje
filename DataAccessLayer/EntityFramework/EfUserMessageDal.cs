using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessages>, IUserMessageDal
    {
        public List<UserMessages> GetUserMessagesWithUser()
        {
            using (var c = new Context())
            {
                return c.userMessages.Include(x => x.User).ToList();
            }
        }
    }
}
