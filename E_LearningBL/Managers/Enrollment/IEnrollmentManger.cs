using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public interface IEnrollmentManger
    {
        public List<DisplayAllEnrollmentDto> DisplayAllEnrollment();
        public void NewEnrollment(AddNewEnrollmentDto newEnrollment);
        public bool IfEnrollmentIsNotExist(AddNewEnrollmentDto newEnrollment);

        public decimal TotalIncome();

    }
}
