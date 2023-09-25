using E_LearningBL.Dtos.InstractorDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public interface IInstractorManger
    {
        public List<InstractorInfoDto> GetAllInstractorsInfo();
        public void AddInstractor(AddNewInstractorDto newInstractor);
    }
}
