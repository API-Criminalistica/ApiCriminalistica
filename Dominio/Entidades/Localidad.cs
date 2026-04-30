namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa una localidad de Bogotá.
    /// </summary>
    public class Localidad
    {
        /// <summary>
        /// Identificador unico de la localidad.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la localidad.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Numero respectivo de la localidad.
        /// </summary>
        public int? NumeroLocalidad { get; set; }

        /// <summary>
        /// Codigo postal de la localidad.
        /// </summary>
        public int? CodigoPostal { get; set; }
    }
}
