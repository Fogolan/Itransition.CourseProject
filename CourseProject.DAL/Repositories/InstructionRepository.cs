using System.Linq;
using CourseProject.DAL.Entities;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CourseProject.DAL.Repositories
{
    public class InstructionRepository : IRepositoryGettable<Instruction>
    {
        private ApplicationContext db;

        public InstructionRepository(ApplicationContext context)
        {
            db = context;
        }

        public void Create(Instruction item)
        {
            db.Instructions.Add(item);
        }

        public void Delete(int id)
        {
            Instruction instruction = db.Instructions.Find(id);
            if (instruction != null)
                db.Instructions.Remove(instruction);
        }

        public IEnumerable<Instruction> Find(Func<Instruction, bool> predicate)
        {
            return db.Instructions.Where(predicate).ToList();
        }

        public Instruction Get(int id)
        {
            return db.Instructions.Find(id);
        }

        public IEnumerable<Instruction> GetAll()
        {
            return db.Instructions;
        }

        public void Update(Instruction item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
