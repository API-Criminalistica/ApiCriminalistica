namespace Aplicacion.Interfaces
{
    using Aplicacion.DTOs;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz para el servicio de gestión de tipos de delito.
    /// </summary>
    public interface ITipoDelitoServicio
    {
        Task<IEnumerable<TipoDelitoDTO>> GetAll();
    }
}
