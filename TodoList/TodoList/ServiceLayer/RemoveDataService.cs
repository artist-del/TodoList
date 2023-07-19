using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.BusinessLayer;
using TodoList.DataAccessLayer;

namespace TodoList.ServiceLayer
{
    public class RemoveDataService
    {
        public bool RemoveTodoInfo(int id)
        {
            return new TodoInfoBusiness(new DLInfoAccess()).RemoveTodoInfo(id);
        }
    }
}