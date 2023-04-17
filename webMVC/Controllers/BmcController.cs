using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class BmcController : Controller
    {
        public IActionResult Bmc()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Content()
        {
            return Content("This is a content return test by action.");
        }
        
        public ContentResult Contents()
        {
            return Content("This is a content return test by ContentResult.");
        }
        public JsonResult json()
        {
            return Json(new {name = "suman", college = "BMC"});
        }
        public IActionResult Partial()
        {
            return PartialView("Bmc");  // layout is discarded
        }
        public IActionResult Download()
        {
            return File("myfiles/hello.txt", "text/plain", "myfile.txt");
        }
    }
}