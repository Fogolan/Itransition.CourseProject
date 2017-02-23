namespace CourseProject.BLL.DTO
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? InstructionId { get; set; }
        public string Contetnt { get; set; }
    }
}
