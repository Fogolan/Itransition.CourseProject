using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.BLL.DTO;
using System.Security.Claims;
using CourseProject.BLL.Interfaces;
using CourseProject.BLL.Infrastructure;

namespace CourseProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}