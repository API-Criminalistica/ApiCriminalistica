namespace Aplicación.Servicios
{
    using Aplicación.DTOs;
    using Aplicación.Interfaces;
    using Dominio.Entidades;
    using Dominio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Servicio para la gestión de ubicaciones.
    /// </summary>
    public class UbicacionServicio : IUbicacionServicio
    {
        private readonly IUbicacionRepositorio _repo;

        public UbicacionServicio(IUbicacionRepositorio repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<UbicacionDTO>> GetAll()
        {
            var ubicaciones = await _repo.GetAll();
            return ubicaciones.Select(u => new UbicacionDTO
            {
                Id = u.Id,
                Latitud = u.Latitud,
                Longitud = u.Longitud,
                Barrio = u.Barrio.Nombre,
                Localidad = u.Localidad.Nombre,
            });
        }

        public async Task<IEnumerable<UbicacionDTO>> GetByBarrio(int barrioId)
        {
            var ubicaciones = await _repo.GetByBarrio(barrioId);
            return ubicaciones.Select(u => new UbicacionDTO
            {
                Id = u.Id,
                Latitud = u.Latitud,
                Longitud = u.Longitud,
                Barrio = u.Barrio.Nombre,
                Localidad = u.Localidad.Nombre,
            });
        }
    }
}