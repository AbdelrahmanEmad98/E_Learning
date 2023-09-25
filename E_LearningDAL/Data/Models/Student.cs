using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; } = null;
        public string Email { get; set; } = null!;
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public List<StudentQuizes> StudentQuizes { get; set; } = new List<StudentQuizes>();
        public List<Certificate> Certificates { get; set; } = new List<Certificate>();

    }
}
