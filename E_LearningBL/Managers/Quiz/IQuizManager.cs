﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public interface IQuizManager
    {
        public void AddQuizToCourse (AddQuizDto newQuiz);
    }
}
