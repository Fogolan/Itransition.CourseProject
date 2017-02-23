using CourseProject.DAL.Entities;
using System;

namespace CourseProject.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryGettable<Instruction> Instructions { get; }
        IRepositoryUpdatable<Step> Steps { get; }
        IRepository<Tag> Tags { get; }
        IRepository<Comment> Comments { get; }
        IRepositoryGettable<User> Users { get; }

        void Save();
    }
}
