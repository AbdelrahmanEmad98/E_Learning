using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    [PrimaryKey(nameof(StudentId),nameof(QuizId))]
    public class StudentQuizes
    {
        public int StudentId { get; set; }
        public Student Studdent { get; set; } = null!;

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;

        public Status Status { get; set; } = Status.NotCompleted;

        public DateTime DateTime { get; set; }

    }
}
