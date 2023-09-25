using E_LearningDAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class QuizRepo : GenericRepo<Quiz>, IQuizRepo
    {
        public QuizRepo(E_LearningAppContext context) : base(context)
        {
        }
    }
}
