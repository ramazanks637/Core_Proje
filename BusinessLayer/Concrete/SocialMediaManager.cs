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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Add(SocialMedia Entity)
        {
            _socialMediaDal.Insert(Entity);
        }

        public void Delete(SocialMedia Entity)
        {
            _socialMediaDal.Delete(Entity);
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetList()
        {
            return _socialMediaDal.GetList();
        }

        public void Update(SocialMedia Entity)
        {
            _socialMediaDal.Update(Entity);
        }
    }
}
