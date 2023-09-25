using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class CourseInfoDto
    {
        public int Id {  get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Level { get; set; }
        public List<ModuleInfoDto> Modules { get; set; } = new List<ModuleInfoDto>();
        public decimal Price { get; set; }
        public decimal Duration { get; set; }
        public string InstractorName { get; set; } = null!;
        public QuizInfoDto? QuizInfo { get; set; } 
        public List<EnrollmentForCourseDto> Enrollments { get; set; } = new List<EnrollmentForCourseDto>();

    }
}
