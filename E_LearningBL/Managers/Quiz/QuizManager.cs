using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class QuizManager : IQuizManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuizManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddQuizToCourse(AddQuizDto newQuiz)
        {
            var quiz = new Quiz()
            {
                CourseId = newQuiz.CourseId,
                QuizName = newQuiz.QuizName,
                QuizDescription = newQuiz.QuizDescription,
            };
            _unitOfWork.QuizRepo.Add(quiz);
            _unitOfWork.SaveChanges();
        }
    }
}
