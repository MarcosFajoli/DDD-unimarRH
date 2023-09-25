using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Disciplina>> Get()
        {
            return Ok(_disciplinaRepository.GetDisciplinas());
        }

        [HttpGet("{id}")]
        public ActionResult<Disciplina> GetById(int id)
        {
            return Ok(_disciplinaRepository.GetDisciplinaById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Aluno> CreateDisciplina(Disciplina disciplina)
        {
            _disciplinaRepository.InsertDisciplina(disciplina);
            return CreatedAtAction(nameof(GetById), new { id = disciplina.DisciplinaId }, disciplina);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Disciplina disciplina)
        {
            try
            {
                if (disciplina == null)
                    return NotFound();

                _disciplinaRepository.UpdateDisciplina(disciplina);
                return Ok("Disciplina Atualizada com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] Disciplina disciplina)
        {
            try
            {
                if (disciplina == null)
                    return NotFound();

                _disciplinaRepository.DeleteDisciplina(disciplina);
                return Ok("Disciplina Removida com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
