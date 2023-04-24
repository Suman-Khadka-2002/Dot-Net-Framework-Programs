using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class StudentController : Controller
    {
        IDateService _service;
        public StudentController(IDateService dateService)
        {
            _service = dateService;
        }
        public IActionResult GetDate()
        {

            //DateService dateService = new DateService();
            return Content(_service.GetDate().ToString());
        }

        /*
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StudentView()
        {
            StudentModel suman = new StudentModel();
            suman.FirstName = "Suman";
            suman.LastName = "Khadka";
            suman.Age = 20;
            suman.Address = "Kadaghari";
            suman.CollegeName= "BMC";
            return View(suman);
        }

        public ActionResult StudentsView()
        {
            StudentModel suman = new StudentModel();
            suman.FirstName = "Suman";
            suman.LastName = "Khadka";
            suman.Age = 20;
            suman.Address = "Kadaghari";
            suman.CollegeName = "BMC";

            StudentModel saini = new StudentModel();
            saini.FirstName = "Saini";
            saini.LastName = "Thapa Magar";
            saini.Age = 21;
            saini.Address = "Suryabinayak";
            saini.CollegeName = "BMC";

            StudentModel raj = new StudentModel();
            raj.FirstName = "Raj";
            raj.LastName = "Prajapati";
            raj.Age = 24;
            raj.Address = "Sano Thimi";
            raj.CollegeName = "BMC";

            List<StudentModel> Students = new List<StudentModel>();
            Students.Add(suman);
            Students.Add(saini);
            Students.Add(raj);

            return View(Students);
        }
        */

        public IActionResult College()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();

            StreamReader sr = new StreamReader("wwwroot/college.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] CollegeDetail = line.Split(',');
                CollegeModel college = new CollegeModel();
                college.CollegeName = CollegeDetail[0];
                college.Address = CollegeDetail[1];
                college.University = CollegeDetail[2];
                colleges.Add(college);
                line = sr.ReadLine();
            }
            sr.Close();

            return View(colleges);
        }
        public IActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCollege(CollegeModel college)
        {
            string dataToSave = college.CollegeName + " , " + college.Address + "," + college.University;
            StreamWriter sw = new StreamWriter("wwwroot/college.txt", append: true);
            sw.WriteLine(dataToSave);
            sw.Close();

            return RedirectToAction("College");
        }
        
    }
}
