using MySql.Data.MySqlClient;
using QuickPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickPOS.Controllers
{
    public class LoginController : Controller
    {
        private readonly DatabaseConnectivity db;

        public LoginController()
        {
            db = new DatabaseConnectivity();
        }

        // GET: Login
        public ActionResult Login()
        {
            // Redirect to the dashboard if already logged in
            if (Session["Username"] != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(Users user)
        {
            try
            {
                
                    string query = $"SELECT * FROM Users WHERE Username = '{user.UserName}' AND Password = '{user.Password}'";

                    using (MySqlDataReader reader = db.ExecuteQuery(query))
                    {
                        if (reader.HasRows)
                        {
                            // Successful login
                            Session["Username"] = user.UserName;// Store username in session
                            Console.WriteLine(user.UserName);
                            return RedirectToAction("Index", "Home"); // Redirect to the dashboard or home page
                        }
                        else
                        {
                            ModelState.AddModelError("", "Invalid username or password");
                            return View(user);
                        }
                   }
                
             
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, and show a generic error message
                ModelState.AddModelError("", "An error occurred while processing your request. Please try again later.");
                // You may want to log the exception for further investigation
                Console.WriteLine(ex.Message);
                return View(user);
            }
        }

        // Logout action
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
