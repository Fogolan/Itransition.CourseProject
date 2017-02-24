using System;
using CourseProject.BLL.DTO;
using CourseProject.DAL.Repositories;
using CourseProject.DAL.Entities;
using CourseProject.DAL.Interfaces;
using CourseProject.BLL.Infrastructure;
using CourseProject.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;
namespace CourseProject.BLL.Services
{
    public class InstructionService : IInstractionService
    {
        IUnitOfWork Database { get; set; }

        public InstructionService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public InstructionDTO GetInstruction(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id инструкции", "");
            var instruction = Database.Instructions.Get(id.Value);
            if (instruction == null)
                throw new ValidationException("Инструкция не найдена", "");
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Instruction, InstructionDTO>();
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<Instruction, InstructionDTO>(instruction);
        }

        public IEnumerable<InstructionDTO> GetInstructions()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Instruction, InstructionDTO>();
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<Instruction>, List<InstructionDTO>>(Database.Instructions.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
