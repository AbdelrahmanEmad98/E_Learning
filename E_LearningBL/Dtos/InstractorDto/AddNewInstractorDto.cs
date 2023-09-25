using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class AddNewInstractorDto
    {
        public string Name { get; set; } = null!;
        public string? JobDescription { set; get; }
        public string? PhoneNumber { get; set; }
    }
}
