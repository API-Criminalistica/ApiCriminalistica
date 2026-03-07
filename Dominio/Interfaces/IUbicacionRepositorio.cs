namespace Dominio.Interfaces
{
    using Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa una interfaz sobre el repositorio de la ubicación.
    /// </summary>
    public interface IUbicacionRepositorio
    {
        Task<IEnumerable<Ubicacion>> GetAll();
        Task<Ubicacion> GetById(int id);
        Task<IEnumerable<Ubicacion>> GetByBarrio(int barrioId);
        Task Update (Ubicacion ubicacion);
    }
}
