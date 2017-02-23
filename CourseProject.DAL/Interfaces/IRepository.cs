using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item);
        void Delete(int id);
    }
}
