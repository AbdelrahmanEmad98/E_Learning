using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class EnrollmentManger : IEnrollmentManger
    {
        private readonly IUnitOfWork _unitOfWork;

        public EnrollmentManger(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DisplayAllEnrollmentDto> DisplayAllEnrollment()
        {
            var enrollments = _unitOfWork.EnrollmentRepo.DisplayAllEnrollmentInfo();
            
            var enrollmentsDto = enrollments.Select(e=> new DisplayAllEnrollmentDto ()
            {
                Id = e.EnrollmentId,
                CourseName = e.Course.Title,
                StudentName = e.Student.FirstName + " " + e.Student.LastName,
                CoursePrice = e.Course.Price,
                EntrollmentDate = DateTime.Now,
            }).ToList();

            return enrollmentsDto;
        }

        public bool IfEnrollmentIsNotExist(AddNewEnrollmentDto newEnrollment)
        {
            Enrollment? enrollment = _unitOfWork.EnrollmentRepo.DisplayAll()
                .FirstOrDefault(e=>e.CourseId == newEnrollment.CourseId && e.StudentId == newEnrollment.StudentId);
            if (enrollment == null)
                return true;
            return false;
        }

        public void NewEnrollment(AddNewEnrollmentDto newEnrollment)
        {
            var enrollment1 = _unitOfWork.EnrollmentRepo.DisplayAll();
            if (IfEnrollmentIsNotExist(newEnrollment))
            {
                var enrollment = new Enrollment()
                {
                    StudentId = newEnrollment.StudentId,
                    CourseId = newEnrollment.CourseId,
                    EntrollmentDate = DateTime.Now,
                };

                _unitOfWork.EnrollmentRepo.Add(enrollment);
                _unitOfWork.SaveChanges();
            }
            
              
        }

        public decimal TotalIncome()
        {
            return _unitOfWork.EnrollmentRepo.TotalInCome();
        }
    }
}
