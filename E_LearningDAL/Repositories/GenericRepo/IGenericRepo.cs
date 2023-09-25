using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL
{
    public interface IGenericRepo <T> where T : class
    {
        public List<T> DisplayAll();
        public T? GetById(int id);
        public void Add(T item);
        public void Update(T item);
        public void Remove(T item);

    }
}
