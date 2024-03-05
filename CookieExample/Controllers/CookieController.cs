using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookieExample.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetCookie(string username)
        {
            // Create a new cookie
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1) // Cookie expiration time (1 day in the future)
            };
            Response.Cookies.Append("Username", username, options);

            return RedirectToAction("GetCookie");
        }

        public IActionResult GetCookie()
        {
            // Retrieve the cookie
            string username = Request.Cookies["Username"];

            ViewBag.Username = username;

            return View();
        }
    }
}
