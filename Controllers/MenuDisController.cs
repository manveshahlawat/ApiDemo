using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiDemo.Controllers
{
    public class MenuDisController : Controller
    {
        // GET: MenuDis
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ajaxGet()
        {
            return View();
        }

        public ActionResult DataTableView()
        {
            return View();
        }
    }
}