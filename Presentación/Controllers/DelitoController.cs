namespace Presentación.Controllers
{
    using Aplicacion.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controlador para gestionar los delitos.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DelitoController : ControllerBase
    {
        private readonly IDelitoServicio _servicio;

        public DelitoController(IDelitoServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var delitos = await _servicio.ObtenerTodos();
            return Ok(delitos);
        }
    }
}
