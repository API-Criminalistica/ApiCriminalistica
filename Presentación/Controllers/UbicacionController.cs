namespace Presentación.Controllers
{
    using Aplicacion.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class UbicacionController : ControllerBase
    {
        private readonly IUbicacionServicio _servicio;

        public UbicacionController(IUbicacionServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(
                await _servicio.GetAll()
            );
        }

        [HttpGet("barrio/{id}")]
        public async Task<IActionResult> GetByBarrio(int id)
        {
            return Ok(
                await _servicio.GetByBarrio(id)
            );
        }
    }
}
