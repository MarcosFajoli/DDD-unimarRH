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
    }
}
