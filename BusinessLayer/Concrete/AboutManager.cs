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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About Entity)
        {
            _aboutDal.Insert(Entity);
        }

        public void Delete(About Entity)
        {
            _aboutDal.Delete(Entity);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

        public void Update(About Entity)
        {
            _aboutDal.Update(Entity);
        }
    }
}
