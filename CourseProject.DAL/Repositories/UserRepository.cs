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
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return db.Users.Where(predicate).ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
