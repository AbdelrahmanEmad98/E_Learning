using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class DisplayAllEnrollmentDto
    {
        public int Id {  get; set; }
        public string CourseName { get; set; } = null!;
        public string StudentName { get; set; } = null!;
        public DateTime EntrollmentDate { get; set; }
        public decimal CoursePrice { get; set; }
    }
}
