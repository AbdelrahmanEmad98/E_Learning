using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class AddQuizDto
    {
        public string QuizName { get; set; } = null!;
        public string QuizDescription { get; set; } = null!;
        public int CourseId { get; set; }
    }
}
