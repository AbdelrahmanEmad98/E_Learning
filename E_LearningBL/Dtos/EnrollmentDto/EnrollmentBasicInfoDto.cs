using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class EnrollmentBasicInfoDto
    {
        public string CourseName { get; set; } = null!;
        public DateTime EntrollmentDate { get; set; }

    }
}
