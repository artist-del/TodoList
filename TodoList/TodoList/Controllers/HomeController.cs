using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.ServiceLayer;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {

        private readonly ListDataService _listDataService;

        public HomeController()
        {
            this._listDataService = new ListDataService();
        }
        // GET: Home
        public ActionResult Index()
        {
            var list = this._listDataService._workInfo();
            return View(list);
        }
    }
}