using E_LearningDAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public class InstractorRepo : GenericRepo<Instractor>, IInstractorRepo
    {
        private readonly E_LearningAppContext _context;

        public InstractorRepo(E_LearningAppContext context) : base(context)
        {
            _context = context;
        }

        public List<Instractor> GetAllInfo()
        {
            return _context.Set<Instractor>().Include(i=>i.Courses).ToList();
        }
    }
}
