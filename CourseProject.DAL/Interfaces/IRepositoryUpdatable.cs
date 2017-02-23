using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Interfaces
{
    public interface IRepositoryUpdatable<T> : IRepository<T> where T : class
    {
        void Update(T item);
    }
}
