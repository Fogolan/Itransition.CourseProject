namespace CourseProject.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? InstructionId { get; set; }
        public string Contetnt { get; set; }
    }
}
