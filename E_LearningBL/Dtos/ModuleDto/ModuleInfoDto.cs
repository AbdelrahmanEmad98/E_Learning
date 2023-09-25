using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class ModuleInfoDto
    {
        public string ModuleTitle { get; set; } = null!;
        public List<LessonInfoDto> Lessons { get; set; } = new List<LessonInfoDto>();
    }
}
