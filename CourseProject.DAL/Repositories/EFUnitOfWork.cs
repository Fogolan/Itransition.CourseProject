using System;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using CourseProject.DAL.Entities;

namespace CourseProject.DAL.Repositories
{
    public class EFUnitOfWork : IDisposable, IUnitOfWork
    {
        private InstructionContext db;
        private InstructionRepository instructionRepository;
        private UserRepository userRepository;
        private StepRepository stepRepository;
        private CommentRepository commentRepository;
        private TagRepository tagRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new InstructionContext(connectionString);
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

        public IRepositoryGettable<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
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

        public void Save()
        {
            db.SaveChanges();
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
