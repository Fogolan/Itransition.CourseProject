using System.Collections.Generic;

namespace CourseProject.DAL.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<Instruction> Instructions { get; set; }
        public Tag()
        {
            Instructions = new List<Instruction>();
        }
    }
}
