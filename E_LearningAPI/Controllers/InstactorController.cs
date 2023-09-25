using E_LearningBL;
using E_LearningBL.Dtos.InstractorDto;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstactorController : ControllerBase
    {
        private readonly IInstractorManger _instractorManger;

        public InstactorController(IInstractorManger instractorManger)
        {
            _instractorManger = instractorManger;
        }
        [HttpGet]
        public ActionResult<List<InstractorInfoDto>> GetAllInstractors()
        {
            try
            {
                var instractors = _instractorManger.GetAllInstractorsInfo();
                return instractors;
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult AddInstractor(AddNewInstractorDto newInstractor)
        {
            try
            {
                 _instractorManger.AddInstractor(newInstractor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
