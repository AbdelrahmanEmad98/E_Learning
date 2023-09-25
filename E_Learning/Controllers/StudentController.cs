using E_LearningBL;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        public IActionResult Index()
        {
            var students = _studentManager.GetAllStudentInfo();
            return View(students);
        }
    }
}
