using System;
using CourseProject.DAL.EF;
using CourseProject.DAL.Interfaces;
using CourseProject.DAL.Entities;

namespace CourseProject.DAL.Repositories
{
    class EFUnitOfWork : IDisposable, IUnitOfWork
    {
        private InstructionContext db;
    }
}
