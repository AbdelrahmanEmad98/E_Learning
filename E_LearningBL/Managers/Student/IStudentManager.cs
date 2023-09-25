using E_LearningBL.Dtos.StudentDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public interface IStudentManager
    {
        public List<GetAllStudentInfoDto> GetAllStudentInfo();
        public void AddNewStudent(AddStudentDto newStudent);
        public void UpdateStudent(int id,UpdateStudentDto UpdateStudent);
        public void DeleteStudent(int id);

    }
}
