using CourseProject.DAL.EF;
using CourseProject.DAL.Entities;
using CourseProject.DAL.Interfaces;

namespace CourseProject.DAL.Repositories
{
    public class ClientManager : IClientManager
    {
        public InstructionContext Database { get; set; }
        public ClientManager(InstructionContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
