namespace Aplicación.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// DTO para representar un delito.
    /// </summary>
    public class DelitoDTO
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string TipoDelito { get; set; }
        public DateTime Fecha { get; set; }
    }
}
