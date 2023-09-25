using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public interface IUnitOfWork
    {
        IStudentRepo StudentRepo { get; }
        ICouresRepo CouresRepo { get; }
        IModuleRepo ModuleRepo { get; }
        ILessonRepo LessonRepo { get; }
        IEnrollmentRepo EnrollmentRepo { get; }
        IQuizRepo QuizRepo { get; }
        IInstractorRepo InstractorRepo { get; }
        IStudentsQuizesRepo StudentsQuizesRepo { get; }
        ICertificateRepo CertificateRepo { get; }

        int SaveChanges();

    }
}
