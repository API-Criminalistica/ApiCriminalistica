namespace Infraestructura.Data
{
    using Dominio.Entidades;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Contexto de base de datos para la aplicación.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase AppDbContext utilizando las opciones de configuración
        /// especificadas.
        /// </summary>
        /// <param name="options">Las opciones que se utilizarán para configurar el contexto de la base de datos. No puede ser nulo.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Delito> Delitos { get; set; }
        public DbSet<TipoDelito> TiposDelito { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
    }
}
