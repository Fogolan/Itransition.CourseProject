using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using CourseProject.DAL.Entities;

namespace CourseProject.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ClientProfile> ClientProfiles { get; set; }

        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new ApplicationDbInitializer());
        }
        public ApplicationContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
