using System.Linq;
using CourseProject.DAL.Entities;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private InstructionContext db;

        public CommentRepository(InstructionContext context)
        {
            this.db = context;
        }

        public void Create(Comment item)
        {
            db.Comments.Add(item);
        }

        public void Delete(int id)
        {
            Comment comment = db.Comments.Find(id);
            if (comment != null)
                db.Comments.Remove(comment);
        }

        public IEnumerable<Comment> Find(Func<Comment, bool> predicate)
        {
            return db.Comments.Where(predicate).ToList();
        }
    }
}
