using E_LearningDAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly E_LearningAppContext _context;

        public StudentRepo(E_LearningAppContext context) : base(context)
        {
            _context = context;
        }

        public List<Student> GetStudentsWithInfo()
        {
            return _context.Set<Student>().Include(s=>s.Enrollments)
                                .ThenInclude(e=>e.Course).ToList();
        }
    }
}
