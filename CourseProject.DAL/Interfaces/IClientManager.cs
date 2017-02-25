using CourseProject.DAL.Entities;
using System;

namespace CourseProject.DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create(ClientProfile item);
    }
}
