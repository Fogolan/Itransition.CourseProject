using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using CourseProject.DAL.Entities;

namespace CourseProject.DAL.EF
{
    public class InstructionContext : DbContext
    {
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        static InstructionContext()
        {
            Database.SetInitializer<InstructionContext>(new InstuctionDbInitializer());
        }
        public InstructionContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
