using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        public ActionResult<List<Funcionario>> Get() 
        {
            return Ok(_funcionarioRepository.GetFuncionarios());
        }

        [HttpGet("{id}")]
        public ActionResult<Funcionario> GetById(int id)
        { 
            return Ok(_funcionarioRepository.GetFuncionarioById(id));
        }
    }
}
