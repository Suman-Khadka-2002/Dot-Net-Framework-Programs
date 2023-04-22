using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class StudentController : Controller
    {
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

        public IActionResult College()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();

            return View(colleges);
        }
        public IActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCollege(CollegeModel College)
        {
            string dataToSave = College.CollegeName + " , " + College.Address;
            StreamWriter sw = new StreamWriter("wwwroot/college.txt",true);
            sw.WriteLine(dataToSave);
            sw.Close();

            return RedirectToAction("College");
        }
        [HttpPost]
        public IActionResult Colleges()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();
            StreamReader sr = new StreamReader("wwwroot/college.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] CollegeDetail = line.Split(',');
                CollegeModel College = new CollegeModel();
                College.CollegeName = CollegeDetail[0];
                College.Address = CollegeDetail[1];
                colleges.Add(College);
                line = sr.ReadLine();
            }
            sr.Close();
            return View(colleges);
        }
    }
}
