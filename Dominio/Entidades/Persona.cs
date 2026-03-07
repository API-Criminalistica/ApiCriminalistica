namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa una persona involucrada en un delito, sea victima o testigo.
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Identificador unico de la persona.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string Nombre { get; set; }
        
        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Edad de la persona
        /// </summary>
        public int Edad { get; set; }

        /// <summary>
        /// Tipo de identificación de la persona (por ejemplo, CC, TI, etc.)
        /// </summary>
        public string TipoDocumento { get; set; }
        
        /// <summary>
        /// Numero de identificación de la persona.
        /// </summary>
        public int Documento { get; set; }

    }
}
