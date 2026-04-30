namespace Aplicación.Interfaces
{
    using Aplicación.DTOs;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz para el servicio de gestión de personas.
    /// </summary>
    public interface IPersonaServicio
    {
        Task<IEnumerable<PersonaDTO>> GetAll();
        Task Add(PersonaDTO persona);
    }
}
