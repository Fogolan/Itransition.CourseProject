using System.Linq;
using CourseProject.DAL.Entities;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CourseProject.DAL.Repositories
{
    public class StepRepository : IRepositoryUpdatable<Step>
    {
        private ApplicationContext db;

        public StepRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public void Create(Step item)
        {
            db.Steps.Add(item);
        }

        public void Delete(int id)
        {
            Step step = db.Steps.Find(id);
            if (step != null)
                db.Steps.Remove(step);
        }

        public IEnumerable<Step> Find(Func<Step, bool> predicate)
        {
            return db.Steps.Where(predicate).ToList();
        }

        public void Update(Step item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
