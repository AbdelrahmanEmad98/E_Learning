using E_LearningBL;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentManger _enrollmentManger;

        public EnrollmentController(IEnrollmentManger enrollmentManger)
        {
            _enrollmentManger = enrollmentManger;
        }

        [HttpGet]
        public ActionResult<List<DisplayAllEnrollmentDto>> GetEnrollmentInfo()
        {
            try
            {
                var enrollments=_enrollmentManger.DisplayAllEnrollment();
                return enrollments;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("TotalIncome")]
        public ActionResult<decimal> GetTotalIncome()
        {
            try
            {
                
                return _enrollmentManger.TotalIncome();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult AddEnrollment(AddNewEnrollmentDto addNewEnrollment)
        {
            try
            {
                _enrollmentManger.NewEnrollment(addNewEnrollment);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
