using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public interface ICouresRepo  : IGenericRepo<Course>
    {
        public List<Course> DisplayAllCoursesInfo();
        public Quiz? GetQuizByCourseId(int courseId);
    }
}
