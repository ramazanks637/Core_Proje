using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> 
        where T: class
    {
        void Insert(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
        List<T> GetList();
        T GetById(int id);

    }
}
