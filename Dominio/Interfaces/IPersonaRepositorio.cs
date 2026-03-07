namespace Dominio.Interfaces
{
    using Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interfaz que define las operaciones para acceder a los datos de las personas involucradas en los delitos, ya sean víctimas o testigos.
    /// </summary>
    public interface IPersonaRepositorio
    {
        Task<IEnumerable<Persona>> GetAll();
        Task<Persona> GetById(int id);
        Task Add(Persona persona);
        Task Update(Persona persona);
        Task Delete(int id);
    }
}
