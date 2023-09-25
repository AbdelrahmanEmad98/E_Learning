using E_LearningDAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class EnrollmentRepo : GenericRepo<Enrollment>, IEnrollmentRepo
    {
        private readonly E_LearningAppContext _context;

        public EnrollmentRepo(E_LearningAppContext context) : base(context)
        {
            _context = context;
        }

        public List<Enrollment> DisplayAllEnrollmentInfo()
        {
            return _context.Enrollments.Include(e=>e.Student).Include(e=>e.Course).ToList();
        }

        public decimal TotalInCome()
        {
            return _context.Set<Enrollment>().Include(e=>e.Course).Select(e=>e.Course.Price).Sum();
        }
    }
}
