using E_LearningBL;
using E_LearningBL.Dtos.StudentDto;
using E_LearningDAL;
using E_LearningDAL.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpGet]
        public ActionResult<List<GetAllStudentInfoDto>> GetAllStudentInfo()
        {
            try
            {

                var students = _studentManager.GetAllStudentInfo();
                return students;
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public ActionResult AddNewStudent(AddStudentDto addStudent)
        {
            try
            {
                _studentManager.AddNewStudent(addStudent);  
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public ActionResult AddNewStudent(int id,UpdateStudentDto UpdatedStudent)
        {
            try
            {
                _studentManager.UpdateStudent(id, UpdatedStudent);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public ActionResult DeleteStudent(int id)
        {
            try
            {
                _studentManager.DeleteStudent(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
