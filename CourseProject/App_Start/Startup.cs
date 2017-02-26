using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using CourseProject.BLL.Services;
using Microsoft.AspNet.Identity;
using CourseProject.BLL.Interfaces;
using Autofac;

[assembly: OwinStartup(typeof(CourseProject.App_Start.Startup))]

namespace CourseProject.App_Start
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
           
            // app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

    }
}