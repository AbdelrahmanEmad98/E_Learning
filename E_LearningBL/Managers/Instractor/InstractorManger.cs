using E_LearningBL.Dtos.InstractorDto;
using E_LearningDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningBL
{
    public class InstractorManger : IInstractorManger
    {
        private readonly IUnitOfWork _unitOfWork;

        public InstractorManger(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddInstractor(AddNewInstractorDto newInstractor)
        {
            var instractor = new Instractor()
            {
                Name = newInstractor.Name,
                PhoneNumber = newInstractor.PhoneNumber,
                JobDescription = newInstractor.JobDescription,
            };
            _unitOfWork.InstractorRepo.Add(instractor);
            _unitOfWork.SaveChanges();
        }

        public List<InstractorInfoDto> GetAllInstractorsInfo()
        {
            var instractors= _unitOfWork.InstractorRepo.GetAllInfo();
            var instractorsDto = instractors.Select(x => new InstractorInfoDto()
            {
                InstractorId=x.InstractorId,
                Name = x.Name,
                PhoneNumber = x.PhoneNumber,
                JobDescription = x.JobDescription,
                Courses = x.Courses.Select(c=>c.Title).ToList()
                
            }).ToList();

            return instractorsDto;
        }
    }
}
