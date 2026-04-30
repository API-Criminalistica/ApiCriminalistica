namespace Aplicacion.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase DTO para la entidad Ubicacion.
    /// </summary>
    public class UbicacionDTO
    {
        public int Id { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Barrio { get; set; }
        public string Localidad { get; set; }
    }
}
