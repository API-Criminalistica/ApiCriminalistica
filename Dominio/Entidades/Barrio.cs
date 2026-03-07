namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa un barrio dentro de una localidad de Bogotá.
    /// </summary>
    public class Barrio
    {
        /// <summary>
        /// Identificador unico del barrio.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre que identifica el barrio.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Localidad del barrio.
        /// </summary>
        public Localidad Localidad { get; set; }
    }
}
