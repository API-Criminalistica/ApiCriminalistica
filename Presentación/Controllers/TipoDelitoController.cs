namespace Presentación.Controllers
{
    using Aplicacion.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class TipoDelitoController : ControllerBase
    {
        private readonly ITipoDelitoServicio _servicio;

        public TipoDelitoController(ITipoDelitoServicio servicio)
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
