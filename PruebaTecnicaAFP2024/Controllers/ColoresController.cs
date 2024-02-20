using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaAFP2024.DataAccess.Repositories;

namespace PruebaTecnicaAFP2024.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColoresController : ControllerBase
    {
        private readonly IColorRepository _colorRepository;

        public ColoresController(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_colorRepository.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_colorRepository.Get(id));
        }
    }
}
