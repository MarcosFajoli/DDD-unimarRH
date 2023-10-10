using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        readonly ICargoRepository _cargoRepository;

        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        [HttpGet]
        public ActionResult<List<Cargo>> Get() 
        { 
            return Ok(_cargoRepository.GetCargos());
        }

        [HttpGet("{id}")]
        public ActionResult<Cargo> GetById(int id)
        {
            return Ok(_cargoRepository.GetCargoById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Cargo> CreateAluno(Cargo cargo)
        {
            _cargoRepository.InsertCargo(cargo);
            return CreatedAtAction(nameof(GetById), new { id = cargo.CargoId }, cargo);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Cargo cargo)
        {
            try
            {
                if (cargo == null)
                    return NotFound();

                _cargoRepository.UpdateCargo(cargo);
                return Ok("Cargo atualizado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Cargo cargo)
        {
            try
            {
                if (cargo == null)
                    return NotFound();

                _cargoRepository.DeleteCargo(cargo);
                return Ok("Cargo removido.");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
