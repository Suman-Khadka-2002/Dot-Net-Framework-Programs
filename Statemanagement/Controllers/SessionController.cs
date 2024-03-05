using Microsoft.AspNetCore.Mvc;
using SessionStateManagement.Models; //using models

namespace SessionStateManagement.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Suman");
            HttpContext.Session.SetInt32("Age", 21);

            return ();
        }
        public IActionResult Get()
        {
            string? name = HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("Age");

            if (age.HasValue)
            {
                User newUser = new()
                {
                    Name = name,
                    Age = age
                };
                ViewBag.message = newUser;
            }
            else
            {
                ViewBag.message = "Age not found in session.";
            }

            return View();
        }
    }
}
