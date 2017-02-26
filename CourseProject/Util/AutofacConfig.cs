using CourseProject.BLL.Services;
using System.Web.Mvc;
using System.Collections.Generic;
using System;
using CourseProject.BLL.Interfaces;
using Autofac;
using Autofac.Integration.Mvc;
using CourseProject.BLL.Infrastructure;

namespace CourseProject.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceModule("DefaultConnection"));
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InstructionService>().As<IInstractionService>();
            builder.RegisterType<UserService>().As<IUserService>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}