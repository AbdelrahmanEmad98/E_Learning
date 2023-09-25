using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class Instractor
    {
        public int InstractorId { get; set; }
        public string Name { get; set; } = null!;
        public string? JobDescription { set; get; } = null;
        public string? PhoneNumber { get; set; } = null;
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
