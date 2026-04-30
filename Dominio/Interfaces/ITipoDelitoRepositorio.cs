namespace Dominio.Interfaces
{
    using Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz que define las operaciones para el repositorio de tipos de delitos.
    /// </summary>
    public interface ITipoDelitoRepositorio
    {
        Task<IEnumerable<TipoDelito>> GetAll();
    }
}
