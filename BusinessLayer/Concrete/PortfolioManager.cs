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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio Entity)
        {
            _portfolioDal.Insert(Entity);
        }

        public void Delete(Portfolio Entity)
        {
            _portfolioDal.Delete(Entity);
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

        public void Update(Portfolio Entity)
        {
            _portfolioDal.Update(Entity);
        }
    }
}
