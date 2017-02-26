using System.Linq;
using CourseProject.DAL.Entities;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CourseProject.DAL.Repositories
{
    public class UserRepository : IRepositoryGettable<User>
    {
        private InstructionContext db;

        public UserRepository(InstructionContext context)
        {
            this.db = context;
        }

        public void Create(User item)
        {
            db.UserNames.Add(item);
        }

        public void Delete(int id)
        {
            User user = db.UserNames.Find(id);
            if (user != null)
                db.UserNames.Remove(user);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return db.UserNames.Where(predicate).ToList();
        }

        public User Get(int id)
        {
            return db.UserNames.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.UserNames;
        }

        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
