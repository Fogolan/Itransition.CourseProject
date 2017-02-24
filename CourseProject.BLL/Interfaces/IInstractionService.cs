using CourseProject.BLL.DTO;
using System.Collections.Generic;

namespace CourseProject.BLL.Interfaces
{
    public interface IInstractionService
    {
        InstructionDTO GetInstruction(int? id);
        IEnumerable<InstructionDTO> GetInstructions();
        void Dispose();
    }
}
