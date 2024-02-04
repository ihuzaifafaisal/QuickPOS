using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickPOS.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        public ActionResult Products()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult AddProduct()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }
        public ActionResult EditProduct()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult DeleteProduct()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }


    }
}