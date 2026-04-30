namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa la ubicacion geografica de un delito.
    /// </summary>
    public class Ubicacion
    {
        /// <summary>
        /// Identificador unico de la ubicacion.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único de la localidad asociada.
        /// </summary>
        public int LocalidadId { get; set; }

        /// <summary>
        /// Localidad donde ocurrió el delito.
        /// </summary>
        public Localidad Localidad { get; set; }

        /// <summary>
        /// Obtiene o establece el identificador único del barrio asociado.
        /// </summary>
        public int BarrioId { get; set; }

        /// <summary>
        /// Barrio donde ocurrió el delito.
        /// </summary>
        public Barrio Barrio { get; set; }

        /// <summary>
        /// Latitud de la ubicacion donde ocurrió el delito.
        /// </summary>
        public double Latitud { get; set; }

        /// <summary>
        /// Longitud de la ubicacion donde ocurrió el delito.
        /// </summary>
        public double Longitud { get; set; }
    }
}
