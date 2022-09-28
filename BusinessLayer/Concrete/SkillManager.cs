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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill Entity)
        {
            _skillDal.Insert(Entity);
        }

        public void Delete(Skill Entity)
        {
            _skillDal.Delete(Entity);
        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

        public void Update(Skill Entity)
        {
            _skillDal.Update(Entity);
        }
    }
}
