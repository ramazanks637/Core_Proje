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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void Add(ToDoList Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ToDoList Entity)
        {
            throw new NotImplementedException();
        }

        public ToDoList GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetList()
        {
            return _toDoListDal.GetList();
        }

        public void Update(ToDoList Entity)
        {
            throw new NotImplementedException();
        }
    }
}
