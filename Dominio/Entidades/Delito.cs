namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa un delito en el sistema.
    /// </summary>
    public class Delito
    {
        /// <summary>
        /// Identificador unico del Delito.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nombre del delito.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción breve del delito.
        /// </summary>
        public string? Descripcion { get; set; }

        /// <summary>
        /// Fecha de suceso del delito.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del tipo de delito asociado.
        /// </summary>
        public int TipoDelitoId { get; set; }

        /// <summary>
        /// Identificador unico del tipo de delito.
        /// </summary>
        public TipoDelito TipoDelito { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la ubicación asociada.
        /// </summary>
        public int UbicacionId { get; set; }

        /// <summary>
        /// Ubicación donde ocurrió el delito.
        /// </summary>
        public Ubicacion Ubicacion { get; set; }

        /// <summary>
        /// Identificador unico del estado del delito (por ejemplo, abierto, cerrado, en investigación).
        /// </summary>
        public int IdEstado { get; set; }
    }
}
