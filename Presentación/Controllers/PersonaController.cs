namespace Presentación.Controllers
{
    using Aplicacion.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServicio _servicio;

        public PersonaController(IPersonaServicio servicio)
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
    }
}
