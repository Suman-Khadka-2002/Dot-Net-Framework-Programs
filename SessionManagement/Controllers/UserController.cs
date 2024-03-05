using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionManagement.Models;

namespace SessionManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // Set data in TempData
            TempData["Message"] = "Hello from TempData!";

            return View();
        }

        public IActionResult SetSession(string name, int age)
        {

            // Store data in session
            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);

            return RedirectToAction("GetSession");
        }

        public IActionResult GetSession()
        {
            // Retrieve data from session
            string name = HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("Age");

            User newUser = new User()
            {
                Name = name,
                Age = age
            };

            return View(newUser);
        }
        public IActionResult DisplayMessage()
        {
            // Retrieve data from TempData
            string message = TempData["Message"] as string;

            if (message != null)
            {
                ViewBag.Message = message;
            }
            else
            {
                ViewBag.Message = "No message in TempData.";
            }

            return View();
        }
    }
}


