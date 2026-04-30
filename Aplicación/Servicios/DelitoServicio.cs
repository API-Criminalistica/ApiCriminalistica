namespace Aplicacion.Servicios
{
    using Aplicacion.DTOs;
    using Aplicacion.Interfaces;
    using Dominio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Servicio para manejar operaciones relacionadas con delitos.
    /// </summary>
    public class DelitoServicio : IDelitoServicio
    {
        private readonly IDelitoRepositorio _repo;

        public DelitoServicio(IDelitoRepositorio repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<DelitoDTO>> ObtenerTodos()
        {
            var delitos = await _repo.GetAll();
            return delitos.Select(d => new DelitoDTO
            {
                Latitud = d.Ubicacion.Latitud,
                Longitud = d.Ubicacion.Longitud,
                TipoDelito = d.TipoDelito.Nombre,
                Fecha = d.Fecha
            });

        }
    }
}
