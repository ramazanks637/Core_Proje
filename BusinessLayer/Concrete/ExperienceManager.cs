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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience Entity)
        {
            _experienceDal.Insert(Entity);
        }

        public void Delete(Experience Entity)
        {
            _experienceDal.Delete(Entity);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

        public void Update(Experience Entity)
        {
            _experienceDal.Update(Entity);
        }
    }
}
