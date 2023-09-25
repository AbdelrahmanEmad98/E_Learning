using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL  
{
    public class AddNewEnrollmentDto
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime EntrollmentDate { get; set; }
        
    }
}
