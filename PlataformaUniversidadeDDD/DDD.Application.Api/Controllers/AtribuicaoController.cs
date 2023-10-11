using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtribuicaoController : ControllerBase
    {
        readonly IAtribuicaoRepository _atribuicaoRepository;

        public AtribuicaoController(IAtribuicaoRepository atribuicaoRepository)
        {
            _atribuicaoRepository = atribuicaoRepository;
        }

        [HttpGet]
        public ActionResult<List<Atribuicao>> Get() 
        { 
            return Ok(_atribuicaoRepository.GetAtribuicoes());
        }

        [HttpGet("{id}")]
        public ActionResult<Atribuicao> GetById(int id)
        {
            return Ok(_atribuicaoRepository.GetAtribuicaoById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Atribuicao> CreateAluno(Atribuicao atribuicao)
        {
            _atribuicaoRepository.InsertAtribuicao(atribuicao);
            return CreatedAtAction(nameof(GetById), new { id = atribuicao.AtribuicaoId }, atribuicao);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Atribuicao atribuicao)
        {
            try
            {
                if (atribuicao == null)
                    return NotFound();

                _atribuicaoRepository.UpdateAtribuicao(atribuicao);
                return Ok("Atribuição atualizada.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Atribuicao atribuicao)
        {
            try
            {
                if (atribuicao == null)
                    return NotFound();

                _atribuicaoRepository.DeleteAtribuicao(atribuicao);
                return Ok("Atribuição removida.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
