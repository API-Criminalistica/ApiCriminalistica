namespace Infraestructura.Repositorios
{
    using Dominio.Entidades;
    using Dominio.Interfaces;
    using Infraestructura.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Repositorio para manejar las operaciones de los tipos de delitos.
    /// </summary>
    public class TipoDelitoRepositorio : ITipoDelitoRepositorio
    {
        private readonly AppDbContext _context;

        public TipoDelitoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoDelito>> GetAll()
        {
            return await _context.TiposDelito.ToListAsync();
        }
    }
}
