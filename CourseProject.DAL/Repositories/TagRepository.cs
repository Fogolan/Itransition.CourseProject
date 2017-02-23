using System.Linq;
using CourseProject.DAL.Entities;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private InstructionContext db;

        public TagRepository(InstructionContext context)
        {
            this.db = context;
        }

        public void Create(Tag item)
        {
            db.Tags.Add(item);
        }

        public void Delete(int id)
        {
            Tag tag = db.Tags.Find(id);
            if (tag != null)
                db.Tags.Remove(tag);
        }

        public IEnumerable<Tag> Find(Func<Tag, bool> predicate)
        {
            return db.Tags.Where(predicate).ToList();
        }
    }
}
