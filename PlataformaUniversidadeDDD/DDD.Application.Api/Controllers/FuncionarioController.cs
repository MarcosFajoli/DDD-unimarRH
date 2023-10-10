using DDD.Domain.HRContext;
using DDD.Domain.SecretariaContext;
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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Funcionario> CreateAluno(Funcionario funcionario)
        {
            _funcionarioRepository.InsertFuncionario(funcionario);
            return CreatedAtAction(nameof(GetById), new { id = funcionario.UserId }, funcionario);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Funcionario funcionario)
        {
            try
            {
                if (funcionario == null)
                    return NotFound();

                _funcionarioRepository.UpdateFuncionario(funcionario);
                return Ok("Funcionário atualizado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Funcionario funcionario)
        {
            try
            {
                if (funcionario == null)
                    return NotFound();

                _funcionarioRepository.DeleteFuncionario(funcionario);
                return Ok("Funcionário removido.");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
