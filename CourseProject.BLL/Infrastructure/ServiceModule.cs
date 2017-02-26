using Autofac;
using CourseProject.DAL.Interfaces;
using CourseProject.DAL.Repositories;

namespace CourseProject.BLL.Infrastructure
{
    public class ServiceModule : Module
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFUnitOfWork>().As<IUnitOfWork>()
                .WithParameter("connectionString", connectionString);
            
        }
    }
}
