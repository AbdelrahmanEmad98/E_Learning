using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    [PrimaryKey(nameof(CertificateId), nameof(StudentId),nameof(CourseId))]

    public class Certificate
    {
        public int CertificateId { set; get; }
        public string CertificateName { set; get; } = null!;
        public DateTime CertificateDate { set; get; }

        public int CourseId { set; get; }
        public Course Course { set; get; } = null!;
        public int StudentId { set; get; }
        public Student Student { set; get; } = null!;
    }
}
