using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; } 

        public int CourseId { get; set; }
        public Course? Course { get; set; } 

        public int ModuleId { get; set; }
        public Module? Module { get; set; } 

        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; } 

        public ProgressStatus Status { get; set; } = ProgressStatus.NotCompleted;


    }
}
