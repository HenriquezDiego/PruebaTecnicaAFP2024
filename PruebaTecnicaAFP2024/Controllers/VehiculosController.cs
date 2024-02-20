using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaAFP2024.DataAccess.Repositories;
using PruebaTecnicaAFP2024.Models;
using PruebaTecnicaAFP2024.ViewModels;

namespace PruebaTecnicaAFP2024.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculoRepository _repository;
        private readonly IMapper _mapper;

        public VehiculosController(IVehiculoRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            if (!result.Any()) return BadRequest();
            return Ok(_mapper.Map<IEnumerable<VehiculoViewModel>>(result));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _repository.GetAsync(id);
            if (result == null) return NotFound();
            return Ok(_mapper.Map<VehiculoViewModel>(result));
        }

        [HttpPost]
        public IActionResult Post(VehiculoInput model)
        {
            var vehiculo = _mapper.Map<Vehiculo>(model);
            _repository.Add(vehiculo);
            if(_repository.Complete()) return Ok(vehiculo);
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,VehiculoInput model)
        {
            var result = await _repository.GetAsync(id);
            if (result == null) return NotFound();
            _mapper.Map(model, result);
            return _repository.Complete() ? Ok(_mapper.Map<VehiculoViewModel>(result)) : BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _repository.GetAsync(id);
            if (result == null) return NotFound();
            _repository.Remove(result);
            return _repository.Complete() ? StatusCode((int)HttpStatusCode.NoContent) : BadRequest();
        }
    }
}
