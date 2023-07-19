using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.BusinessLayer;
using TodoList.DataAccessLayer;

namespace TodoList.ServiceLayer
{
    public class AddDataService
    {
        public bool AddTodoInfo(string nameSchedule)
        {
            return new TodoInfoBusiness(new DLInfoAccess()).AddTodoInfo(nameSchedule);
        }
    }
}