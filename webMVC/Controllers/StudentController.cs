using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data.SqlClient;
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
        
        public IActionResult Students()
        {
            List<StudentsModel> students = new List<StudentsModel>();
            return View(students);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        //making action to save to db
        //form always uses POST
        [HttpPost]
        public IActionResult AddToDatabase(StudentsModel students)   //student ma form data aauxa
        {
            //1. connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bmc;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection conn = new SqlConnection (connectionString); //2. connection
            conn.Open(); //3. open connection
            string command = "Insert into Students (Id, StudentName, Address, Course) Values (1, 'Suman', 'Kathmandu', 'CSIT'), (2, 'John', 'New York', 'Engineering'), (3, 'Mary', 'London', 'Business'), (4, 'Tanjiro Kamado', 'Mt.Kumotori, Okutama', 'Water Breathing Style')";            // sql command
            SqlCommand cmd = new SqlCommand (command, conn);  //4. sql command this turn string above to sql command
            cmd.ExecuteNonQuery ();  //5. because its not a query now
            conn.Close(); //6.

            return View(); 
        }
    }
}
