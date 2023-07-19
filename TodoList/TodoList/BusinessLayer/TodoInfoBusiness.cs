using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.Models;

namespace TodoList.BusinessLayer
{
    public class TodoInfoBusiness
    {
        private readonly ITodoInfoBusiness _todoInfoBusiness;

        public TodoInfoBusiness(ITodoInfoBusiness todoInfoBusiness)
        {
            this._todoInfoBusiness = todoInfoBusiness;
        }

        public List<WorkInfo> ListTodoInfo()
        {
            return _todoInfoBusiness.ListTodoInfo();
        }

        public bool AddTodoInfo(string nameSchedule)
        {
            return this._todoInfoBusiness.AddTodoInfo(nameSchedule);
        }

        public bool EditTodoInfo(int id, string nameSchedule)
        {
            return this._todoInfoBusiness.EditTodoInfo(id, nameSchedule);
        }

        public bool RemoveTodoInfo(int id)
        {
            return this._todoInfoBusiness.RemoveTodoInfo(id);
        }
    }
}