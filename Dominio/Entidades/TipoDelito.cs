namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que define el tipo de delito, que puede ser utilizado para categorizar los delitos registrados en el sistema.
    /// </summary>
    public class TipoDelito
    {
        /// <summary>
        /// Identificador unico del tipo de delito.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del tipo de delito.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción breve del tipo de delito.
        /// </summary>
        public string? Descripcion { get; set; }
    }
}
