using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    [PrimaryKey(nameof(QuizId),nameof(CourseId))]
    public class Quiz
    {
        public int QuizId { get; set; }
        public string QuizName { get; set; } = null!;
        public string QuizDescription { get; set; } = null!;
        public int CourseId { get; set; }   
        public Course Course { get; set;} = null!;
        public List<StudentQuizes> StudentsForQuize { get; set; } = new List<StudentQuizes>();


    }
}
