using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseProject.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
