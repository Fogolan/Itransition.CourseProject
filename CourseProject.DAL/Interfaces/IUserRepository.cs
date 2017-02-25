using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.DAL.Interfaces
{
    public interface IUserRepository<T> : IRepositoryGettable<T> where T : class
    {
        Task<bool> LoginAsync(T item);
    }
}
