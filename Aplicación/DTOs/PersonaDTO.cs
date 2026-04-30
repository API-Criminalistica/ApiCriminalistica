namespace Aplicación.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase DTO para la entidad Persona.
    /// </summary>
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
    }
}
