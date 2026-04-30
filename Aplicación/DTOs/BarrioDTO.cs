namespace Aplicación.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// clase DTO para la entidad Barrio. 
    /// </summary>
    public class BarrioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
    }
}
