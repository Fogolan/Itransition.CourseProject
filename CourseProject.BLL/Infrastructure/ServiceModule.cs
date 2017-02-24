using Ninject.Modules;
using CourseProject.DAL.Interfaces;
using CourseProject.DAL.Repositories;
using System;

namespace CourseProject.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
