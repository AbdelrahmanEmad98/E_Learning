using E_LearningDAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class CourseRepo : GenericRepo<Course>, ICouresRepo
    {
        private readonly E_LearningAppContext _context;

        public CourseRepo(E_LearningAppContext context) : base(context)
        {
            _context = context;
        }

        public List<Course> DisplayAllCoursesInfo()
        {
           return _context.Set<Course>().Include(c=>c.Modules).ThenInclude(m=>m.Lessons)
                .Include(c=>c.Enrollments).ThenInclude(e=>e.Student).Include(c=>c.Instractor).ToList();
        }

        public Quiz? GetQuizByCourseId(int courseId)
        {
            return _context.Set<Quiz>()?.FirstOrDefault(q=>q.CourseId == courseId) ?? null ;
        }
    }
}
