using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class AddCourseDto
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public CourseLevel Level { get; set; }
        public decimal Price { get; set; }
        public decimal Duration { get; set; }
        public int InstractorId { get; set; }
        public List<ModuleInfoDto> Modules { get; set; } = new List<ModuleInfoDto>();
    }
}
