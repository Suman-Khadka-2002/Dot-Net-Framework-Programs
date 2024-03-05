using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JqueryExample.Models;

namespace JqueryExample.Controllers
{
    public class JqueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                // Process the user's data (you can save it to a database or perform other actions here)
                return RedirectToAction("Details", userModel);
            }

            // If the model is not valid, return to the form with errors
            return View("Index", userModel);
        }

        public IActionResult Details(UserModel userModel)
        {
            return View(userModel);
        }
    }
}
