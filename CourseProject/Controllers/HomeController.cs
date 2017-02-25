using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseProject.BLL.Interfaces;
using CourseProject.BLL.DTO;
using CourseProject.Models;
using AutoMapper;
using CourseProject.BLL.Infrastructure;

namespace CourseProject.Controllers
{
    public class HomeController : Controller
    {
        IInstructionService instructionService;
        IMapper mapper;
        public HomeController(IInstructionService serv)
        {
            instructionService = serv;
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<InstructionDTO, InstructionViewModel>();
            });
            mapper = config.CreateMapper();
        }
        public ActionResult Index()
        {
            var instructions = mapper.Map<IEnumerable<InstructionDTO>, List<InstructionViewModel>>(instructionService.GetInstructions());
            return View(instructions);
        }
        protected override void Dispose(bool disposing)
        {
            instructionService.Dispose();
            base.Dispose(disposing);
        }
    }
}