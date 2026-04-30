namespace Aplicacion.Interfaces
{
    using Aplicacion.DTOs;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz para el servicio de delitos.
    /// </summary>
    public interface IDelitoServicio
    {
        Task<IEnumerable<DelitoDTO>> ObtenerTodos();
    }
}
