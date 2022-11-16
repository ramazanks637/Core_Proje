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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Announcement Entity)
        {
            throw new NotImplementedException();
        }

        public Announcement GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetList()
        {
            return _announcementDal.GetList();
        }

        public void Update(Announcement Entity)
        {
            throw new NotImplementedException();
        }
    }
}
