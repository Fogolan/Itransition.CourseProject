using System;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using CourseProject.DAL.Entities;
using CourseProject.DAL.Identity;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseProject.DAL.Repositories
{
    public class EFUnitOfWork : IDisposable, IUnitOfWork
    {
        private ApplicationContext db;
        private InstructionRepository instructionRepository;
        private StepRepository stepRepository;
        private CommentRepository commentRepository;
        private TagRepository tagRepository;
        private ApplicationUserManager userManager;
        private ApplicationRoleManager roleManager;
        private IClientManager clientManager;

        public EFUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
            userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(db));
            clientManager = new ClientManager(db);

        }

        public IRepositoryGettable<Instruction> Instructions
        {
            get
            {
                if (instructionRepository == null)
                    instructionRepository = new InstructionRepository(db);
                return instructionRepository;
            }
        }

        public IRepositoryUpdatable<Step> Steps
        {
            get
            {
                if (stepRepository == null)
                    stepRepository = new StepRepository(db);
                return stepRepository;
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }

        public IRepository<Tag> Tags
        {
            get
            {
                if (tagRepository == null)
                    tagRepository = new TagRepository(db);
                return tagRepository;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return userManager;
            }
        }

        public IClientManager ClientManager
        {
            get
            {
                return clientManager;
            }
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return roleManager;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
