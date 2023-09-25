using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public interface IEnrollmentRepo : IGenericRepo<Enrollment>
    {
        public List<Enrollment>DisplayAllEnrollmentInfo();
        public decimal TotalInCome();
    }
}
