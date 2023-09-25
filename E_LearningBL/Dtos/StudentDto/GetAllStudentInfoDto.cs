using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class GetAllStudentInfoDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string Email { get; set; } = null!;
        public List<EnrollmentBasicInfoDto> Enrollments { get; set; } = new List<EnrollmentBasicInfoDto>();
    }
}
