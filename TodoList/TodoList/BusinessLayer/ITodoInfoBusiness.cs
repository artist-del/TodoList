using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList
{
    public interface ITodoInfoBusiness
    {
        List<WorkInfo> ListTodoInfo();
        bool AddTodoInfo(string nameSchedule);
        bool EditTodoInfo(int id, string nameSchedule);
        bool RemoveTodoInfo(int id);
    }
}
