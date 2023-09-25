using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public interface IStudentRepo : IGenericRepo<Student>
    {
        public List<Student> GetStudentsWithInfo();
    }
}
