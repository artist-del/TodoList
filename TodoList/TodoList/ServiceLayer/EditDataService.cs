using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.BusinessLayer;
using TodoList.DataAccessLayer;

namespace TodoList.ServiceLayer
{
    public class EditDataService
    {
        public bool EditTodoInfo(int id, string nameSchedule)
        {
            return new TodoInfoBusiness(new DLInfoAccess()).EditTodoInfo(id, nameSchedule);
        }
    }
}