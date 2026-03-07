namespace Dominio.Interfaces
{
    using Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clase que representa la interfaz de un repositorio para acceder a los datos de los delitos.
    /// </summary>
    public interface IDelitoRepositorio
    {
        Task<IEnumerable<Delito>> GetAll();
        Task<Delito> GetById(int id);
    }
}
