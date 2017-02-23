namespace CourseProject.BLL.DTO
{
    public class StepDTO
    {
        public int Id { get; set; }
        public string StepName { get; set; }
        public int NumberOfStep { get; set; }
        public string PathToImage { get; set; }
        public string Description { get; set; }
        public int? InstructionId { get; set; }
    }
}
