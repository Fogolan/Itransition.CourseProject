using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using CourseProject.BLL.Services;
using Microsoft.AspNet.Identity;
using CourseProject.BLL.Interfaces;
using CourseProject.BLL.Interfaces;

[assembly: OwinStartup(typeof(UserStore.App_Start.Startup))]

namespace UserStore.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.CreatePerOwinContext<IUserService>(IUserService.Create);
            //app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        //private IUserService CreateUserService()
        //{
        //    return serviceCreator.CreateUserService("DefaultConnection");
        //}
    }
}