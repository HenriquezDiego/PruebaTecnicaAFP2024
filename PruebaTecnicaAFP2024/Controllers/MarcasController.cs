using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaAFP2024.DataAccess.Repositories;

namespace PruebaTecnicaAFP2024.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasController : ControllerBase
    {
        private readonly IMarcaRepository _repository;

        public MarcasController(IMarcaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
