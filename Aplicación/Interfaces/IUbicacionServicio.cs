namespace Aplicación.Interfaces
{
    using Aplicación.DTOs;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz para el servicio de gestión de ubicaciones.
    /// </summary>
    public interface IUbicacionServicio
    {
        Task<IEnumerable<UbicacionDTO>> GetAll();
        Task<IEnumerable<UbicacionDTO>> GetByBarrio(int barrioId);
    }
}
