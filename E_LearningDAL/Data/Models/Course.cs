using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class Course
    {
        public int CourseId {get; set;}
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public CourseLevel Level { get; set;}
        public decimal Price { get; set;}
        public decimal Duration { get; set;}
        public int? QuizId { get; set; } = null;
        public Quiz? Quiz { get; set; } = null;
        public int InstractorId { get; set; }
        public Instractor Instractor { get; set; } = null!;
        public List<Module> Modules { get; set;} = new List<Module>();
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
