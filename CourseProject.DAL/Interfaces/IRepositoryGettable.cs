using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Interfaces
{
    public interface IRepositoryGettable<T> : IRepositoryUpdatable<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
