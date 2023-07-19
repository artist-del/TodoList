using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Models;
using TodoList.ServiceLayer;

namespace TodoList.Controllers
{
    public class TodoListController : Controller
    {
        private readonly AddDataService _addDataService;
        private readonly EditDataService _editDataService;
        private readonly RemoveDataService _removeDataService;
        private readonly ListDataService _listDataService;

        public TodoListController()
        {
            this._addDataService = new AddDataService();
            this._editDataService = new EditDataService();
            this._removeDataService = new RemoveDataService();
            this._listDataService = new ListDataService();
        }
        // GET: TodoList
        [HttpGet]
        public ActionResult GetDataTodoInfo()
        {
            var list = this._listDataService._workInfo();

            return Json(new
            {
                data = list
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditCreateTodoInfo(WorkInfo data)
        {
            bool result = this._editDataService.EditTodoInfo(data.Id, data.NameSchedule);
            if (result)
            {
                return Json(new
                {
                    msg = true
                });
            }
            else
            {
                return Json(new
                {
                    msg = false
                });
            }
        }

        [HttpPost]
        public ActionResult RemoveTodoInfo(int _id)
        {
            var result = this._removeDataService.RemoveTodoInfo(_id);

            if (result)
            {
                return Json(new
                {
                    msg = "Data Deleted Successfully"
                });
            }else
            {
                return Json(new
                {
                    msg = "Something Wrong!"
                });
            }
        }
    }
}