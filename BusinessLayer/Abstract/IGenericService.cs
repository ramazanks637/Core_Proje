﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
        List<T> GetList();
        T GetById(int id);
    }
}
