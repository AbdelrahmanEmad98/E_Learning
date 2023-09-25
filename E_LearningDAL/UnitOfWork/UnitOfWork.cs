using E_LearningDAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly E_LearningAppContext _context;

        public IStudentRepo StudentRepo { get; }
        public ICouresRepo CouresRepo { get; }
        public IQuizRepo QuizRepo { get; }
        public IModuleRepo ModuleRepo { get; }
        public ILessonRepo LessonRepo { get; }
        public IEnrollmentRepo EnrollmentRepo { get; }
        public ICertificateRepo CertificateRepo { get; }
        public IStudentsQuizesRepo StudentsQuizesRepo { get; }
        public IInstractorRepo InstractorRepo { get; }


        public UnitOfWork(E_LearningAppContext context , IStudentRepo studentRepo , ICouresRepo couresRepo,IQuizRepo quizRepo
                          ,IModuleRepo moduleRepo , ILessonRepo lessonRepo , IEnrollmentRepo enrollmentRepo , ICertificateRepo certificateRepo
                          ,IStudentsQuizesRepo studentsQuizesRepo , IInstractorRepo instractorRepo)
        {
            _context = context;
            StudentRepo = studentRepo;
            CouresRepo = couresRepo;
            QuizRepo = quizRepo;
            ModuleRepo = moduleRepo;
            LessonRepo = lessonRepo;
            EnrollmentRepo = enrollmentRepo;
            CertificateRepo = certificateRepo;
            StudentsQuizesRepo = studentsQuizesRepo;
            InstractorRepo = instractorRepo;
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
