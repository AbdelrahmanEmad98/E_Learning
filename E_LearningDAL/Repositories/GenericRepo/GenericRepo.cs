using E_LearningDAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL;
public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly E_LearningAppContext _context;

    public GenericRepo(E_LearningAppContext context)
    {
        _context = context;
    }
    public List<T> DisplayAll()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Add(T item)
    {
        _context.Set<T>().Add(item);
    }



    public void Update(T item)
    {
       // _context.Set<T>().Update(item);
    }
    public void Remove(T item)
    {
        _context.Set<T>().Remove(item);
    }
}

