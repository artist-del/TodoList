using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.BusinessLayer;
using TodoList.DataAccessLayer;
using TodoList.Models;

namespace TodoList.ServiceLayer
{
    public class ListDataService
    {
        public List<WorkInfo> _workInfo()
        {
            return new TodoInfoBusiness(new DLInfoAccess()).ListTodoInfo();
        }
    }
}