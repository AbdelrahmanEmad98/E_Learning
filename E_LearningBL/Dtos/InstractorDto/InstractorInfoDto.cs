using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL.Dtos.InstractorDto
{
    public class InstractorInfoDto
    {
        public int InstractorId { get; set; }
        public string Name { get; set; } = null!;
        public string? JobDescription { set; get; }
        public string? PhoneNumber { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
    }
}
