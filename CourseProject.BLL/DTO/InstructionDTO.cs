using System;

namespace CourseProject.BLL.DTO
{
    public class InstructionDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string InstructionName { get; set; }
        public string Category { get; set; }
        public string LinkToVideo { get; set; }
        public int NumberOfLikes { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
