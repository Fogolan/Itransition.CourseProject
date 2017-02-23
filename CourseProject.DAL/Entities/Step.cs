using System;
using System.Collections.Generic;

namespace CourseProject.DAL.Entities
{
    public class Step
    {
        public int Id { get; set; }
        public string StepName { get; set; }
        public int NumberOfStep { get; set; }
        public string PathToImage { get; set; }
        public string Description { get; set; }
        public int? InstructionId { get; set; }
    }
}
