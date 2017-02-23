using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Entities
{
    public class Instruction
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string InstructionName { get; set; }
        public string Category { get; set; }
        public string LinkToVideo { get; set; }
        public int NumberOfLikes { get; set; }
        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Step> Steps { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Instruction()
        {
            Steps = new List<Step>();
            Tags = new List<Tag>();
            Comments = new List<Comment>();
        }

    }
}
