using E_LearningBL.Dtos.StudentDto;
using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class StudentManager : IStudentManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        

        public List<GetAllStudentInfoDto> GetAllStudentInfo()
        {
            var students = _unitOfWork.StudentRepo.GetStudentsWithInfo();

            var studentsVM = students.Select(x => new GetAllStudentInfoDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                Email = x.Email,
                Enrollments = x.Enrollments.Select(y => new EnrollmentBasicInfoDto()
                {
                    CourseName = y.Course.Title,
                    EntrollmentDate = y.EntrollmentDate
                }).ToList(),

            }).ToList();


            return studentsVM;
        }
        public void AddNewStudent(AddStudentDto newStudent)
        {

            Student nStudent = new Student()
            {
                FirstName = newStudent.FirstName,
                LastName = newStudent.LastName,
                Email = newStudent.Email,
                Address = newStudent.Address,
            };

            _unitOfWork.StudentRepo.Add(nStudent);
            _unitOfWork.SaveChanges();
        }
        public void UpdateStudent(int id, UpdateStudentDto UpdateStudent)
        {
            var student = _unitOfWork.StudentRepo.GetById(id);
            student.FirstName = UpdateStudent.FirstName;
            student.LastName = UpdateStudent.LastName;
            student.Email = UpdateStudent.Email;
            student.Address = UpdateStudent.Address;

            _unitOfWork.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = _unitOfWork.StudentRepo.GetById(id);
            _unitOfWork.StudentRepo.Remove(student);
        }
    }
}
