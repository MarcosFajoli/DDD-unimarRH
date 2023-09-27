using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        readonly IMatriculaRepository _matriculaRepository;

        public MatriculaController(IMatriculaRepository matriculaRepository)
        {
            _matriculaRepository = matriculaRepository; 
        }

        [HttpGet]
        public ActionResult<List<Matricula>> Get()
        {
            return Ok(_matriculaRepository.GetMatriculas());
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> GetById(int id)
        {
            return Ok(_matriculaRepository.GetMatriculaById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Matricula> CreateMatricula(int idAluno, int idDisciplina)
        {
            Matricula matriculaIdSaved = _matriculaRepository.InsertMatricula(idAluno, idDisciplina);
            return CreatedAtAction(nameof(GetById), new { id = matriculaIdSaved.MatriculaId }, matriculaIdSaved);
        }

        //[HttpPut]
        //public ActionResult Put([FromBody] Aluno aluno)
        //{
        //    try
        //    {
        //        if (aluno == null)
        //            return NotFound();

        //        _alunoRepository.UpdateAluno(aluno);
        //        return Ok("Cliente Atualizado com sucesso!");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //// DELETE api/values/5
        //[HttpDelete()]
        //public ActionResult Delete([FromBody] Aluno aluno)
        //{
        //    try
        //    {
        //        if (aluno == null)
        //            return NotFound();

        //        _alunoRepository.DeleteAluno(aluno);
        //        return Ok("Cliente Removido com sucesso!");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

    }
}
