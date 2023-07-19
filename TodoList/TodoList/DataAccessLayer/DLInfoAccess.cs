using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TodoList.Models;

namespace TodoList.DataAccessLayer
{
    public class DLInfoAccess: ITodoInfoBusiness
    {
        private TodoListAppEntities _dbContext;

        public DLInfoAccess()
        {
            this._dbContext = new TodoListAppEntities();
        }

        public List<WorkInfo> ListTodoInfo()
        {
            var list = _dbContext.Database.SqlQuery<WorkInfo>("EXEC pr_ShowListInfo").ToList();
            return list;
        }

        public bool AddTodoInfo(string nameSchedule)
        {

            try
            {
                var addNameSchedule = new SqlParameter("@nameSchedule", SqlDbType.VarChar) { Value= nameSchedule};
                _dbContext.Database.ExecuteSqlCommand("EXEC pr_AddTodoInfo @nameSchedule", addNameSchedule);
                return true;
            }
            catch(System.Exception)
            {
                return false;
            }
        }

        public bool EditTodoInfo(int _id, string _nameSchedule)
        {
            try
            {
                var id = new SqlParameter("@id", SqlDbType.Int) { Value = _id };
                var nameSchedule = new SqlParameter("@nameSchedule", SqlDbType.VarChar) { Value = _nameSchedule };

                _dbContext.Database.ExecuteSqlCommand("EXEC EditCreateTodoInfo @id, @nameSchedule", id, nameSchedule);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool RemoveTodoInfo(int _id)
        {
            try
            {
                var id = new SqlParameter("@id", SqlDbType.Int) { Value = _id };

                this._dbContext.Database.ExecuteSqlCommand("EXEC pr_RemoveTodoInfo @id", id);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}