using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{ 
    public interface ICourseManger
    {
        public List<CourseInfoDto> GettAllCourses();
        public void AddNewCourse(AddCourseDto newCourse); 
        public void DeleteCourse(int id);
    }
}
