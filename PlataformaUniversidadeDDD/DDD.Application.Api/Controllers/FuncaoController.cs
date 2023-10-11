using DDD.Domain.HRContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncaoController : ControllerBase
    {
        readonly IFuncaoRepository _funcaoRepository;
        public FuncaoController(IFuncaoRepository funcaoRepository)
        {
            _funcaoRepository = funcaoRepository;
        }

        [HttpGet]
        public ActionResult<List<Funcao>> Get()
        {
            return Ok(_funcaoRepository.GetFuncoes());
        }

        [HttpGet("{id}")]
        public ActionResult<Funcao> GetById(int id)
        {
            return Ok(_funcaoRepository.GetFuncaoById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Funcao> CreateFuncao(int idFuncionario, int idAtribuicao)
        {
            Funcao funcaoIdSaved = _funcaoRepository.InsertFuncao(idFuncionario, idAtribuicao);
            return CreatedAtAction(nameof(GetById), new { id = funcaoIdSaved.FuncaoId }, funcaoIdSaved);
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Funcao funcao)
        {
            try
            {
                if (funcao == null)
                    return NotFound();

                _funcaoRepository.DeleteFuncao(funcao);
                return Ok("Função removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
