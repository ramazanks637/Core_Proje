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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature Entity)
        {
            _featureDal.Insert(Entity);
        }

        public void Delete(Feature Entity)
        {
            _featureDal.Delete(Entity);
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public void Update(Feature Entity)
        {
            _featureDal.Update(Entity);
        }
    }
}
