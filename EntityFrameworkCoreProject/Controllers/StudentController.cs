using EntityFrameworkCoreProject.EntityData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject.Controllers
{
    public class StudentController : Controller
    {
        EntityDB _entityDB;
        public StudentController(EntityDB entityDB)
        {
            this._entityDB = entityDB;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentIndex()
        {
            List<Student> students = new List<Student>();
            students = _entityDB.Student.ToList();
            return View(students);
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student newStudent)
        {
            _entityDB.Student.Add(newStudent);
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");

        }
        public IActionResult DeleteStudent(int id)
        {
            var student = _entityDB.Student.Where(x => x.Id == id).FirstOrDefault();
            _entityDB.Student.Remove(student);
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");
        }
        public IActionResult EditStudent(int id)
        {
            var student = _entityDB.Student.Where(x => x.Id == id).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            _entityDB.Attach(student);
            _entityDB.Student.Entry(student).State = EntityState.Modified;
            _entityDB.SaveChanges();
            return RedirectToAction("StudentIndex");
        }

        public IActionResult AddSession()
        {
            HttpContext.Session.SetString("Username", "Suman");
            Response.Cookies.Append("Course", "netCentric");

            return View();
        }
        public IActionResult ReadSession()
        {
            string username = HttpContext.Session.GetString("Username");
            ViewBag.Username = username;
            ViewData["college"] = "bmc";
            TempData["address"] = "bhaktapur";
            String course = HttpContext.Request.Cookies["Course"];
            ViewBag.Course = course;

            return View();
        }
        public IActionResult Student(int StudentId)
        {
            ViewBag.studnetId = StudentId;
            return View();
        }
        public IActionResult Jquery()
        {
            return View();
        }
    }
}
