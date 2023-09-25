using E_LearningBL;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizManager _quizManager;

        public QuizController(IQuizManager quizManager)
        {
            _quizManager = quizManager;
        }

        [HttpPost]
        public ActionResult AddQuiz (AddQuizDto addQuiz)
        {
            try
            {
                _quizManager.AddQuizToCourse(addQuiz);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
