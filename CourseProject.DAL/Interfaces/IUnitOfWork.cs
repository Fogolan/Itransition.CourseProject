using CourseProject.DAL.Entities;
using CourseProject.DAL.Identity;
using System;
using System.Threading.Tasks;

namespace CourseProject.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryGettable<Instruction> Instructions { get; }
        IRepositoryUpdatable<Step> Steps { get; }
        IRepository<Tag> Tags { get; }
        IRepository<Comment> Comments { get; }
        IRepositoryGettable<User> Users { get; }
        ApplicationUserManager UserManager { get; }
        IClientManager ClientManager { get; }
        ApplicationRoleManager RoleManager { get; }

        Task SaveAsync();
        void Save();
    }
}
