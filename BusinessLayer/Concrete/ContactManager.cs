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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact Entity)
        {
            _contactDal.Insert(Entity);
        }

        public void Delete(Contact Entity)
        {
            _contactDal.Delete(Entity);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public void Update(Contact Entity)
        {
            _contactDal.Update(Entity);
        }
    }
}
