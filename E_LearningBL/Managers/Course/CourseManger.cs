using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class CourseManger : ICourseManger
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseManger(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddNewCourse(AddCourseDto newCourse )
        {
            
            Course course = new Course()
            {
                Title = newCourse.Title,
                Description = newCourse.Description,
                Price = newCourse.Price,
                Duration = newCourse.Duration,
                InstractorId = newCourse.InstractorId,
                Modules = newCourse.Modules.Select(m => new Module()
                {
                    ModuleTitle = m.ModuleTitle,
                    Lessons = m.Lessons.Select(m => new Lesson()
                    {
                        LessonName = m.LessonName
                    }).ToList(),
                }).ToList()
            };

            _unitOfWork.CouresRepo.Add(course);
            _unitOfWork.SaveChanges();

        }

        

        public List<CourseInfoDto> GettAllCourses()
        {
            var courses = _unitOfWork.CouresRepo.DisplayAllCoursesInfo();

            

            var coursesDto = courses.Select(c => new CourseInfoDto()
            {
                Id = c.CourseId,
                Title = c.Title,
                Description = c.Description,
                Price = c.Price,
                Duration = c.Duration,
                InstractorName = c.Instractor.Name,
                Modules = c.Modules.Select(m => new ModuleInfoDto()
                {
                    ModuleTitle = m.ModuleTitle,
                    Lessons = m.Lessons.Select(l => new LessonInfoDto()
                    {
                        LessonName = l.LessonName,
                    }).ToList(),
                }).ToList(),
                Level = c.Level.ToString(),
                Enrollments = c.Enrollments.Select(e => new EnrollmentForCourseDto()
                {
                    Student = new BasicStudentInfo()
                    {
                        FirstName = e.Student.FirstName,
                        LastName = e.Student.LastName,
                        Email = e.Student.Email,
                    },
                    EntrollmentDate = e.EntrollmentDate
                }).ToList(),
                //Ask ?? 
                QuizInfo = _unitOfWork.CouresRepo.GetQuizByCourseId(c.CourseId) == null ? null : new QuizInfoDto(){
                    QuizName = _unitOfWork.CouresRepo.GetQuizByCourseId(c.CourseId).QuizName ,
                    QuizDescription = _unitOfWork.CouresRepo.GetQuizByCourseId(c.CourseId).QuizName 
                }



            }).ToList();

            return coursesDto;
        }

        public void DeleteCourse(int id)
        {
            var course = _unitOfWork.CouresRepo.GetById(id);
            _unitOfWork.CouresRepo.Remove(course);
            _unitOfWork.SaveChanges();
        }
    }
}
