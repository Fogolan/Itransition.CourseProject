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
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceModule("DefaultConnection"));
            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            // регистрируем споставление типов
            builder.RegisterType<InstructionService>().As<IInstractionService>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}