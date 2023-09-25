using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string ModuleTitle { get; set; } = null!;
        
        public int CourseId { get; set; }
        public Course Course { get; set;} = null!;
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();


    }
}
