using E_LearningBL;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseManger _courseManger;

        public CourseController(ICourseManger courseManger)
        {
            _courseManger = courseManger;
        }

        [HttpGet]
        public ActionResult<List<CourseInfoDto>> GetAllCoursesInfo()
        {
            try
            {
                var Courses = _courseManger.GettAllCourses();
                return Courses;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult AddNewCoures(AddCourseDto newCourse)
        {
            try
            {
               _courseManger.AddNewCourse(newCourse);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        public ActionResult DeleteCourse(int id)
        {
            try
            {
                _courseManger.DeleteCourse(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
