using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickPOS.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        public ActionResult Suppliers()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }
    }
}