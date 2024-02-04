using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickPOS.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Sales()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult SalesReport()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }
    }
}