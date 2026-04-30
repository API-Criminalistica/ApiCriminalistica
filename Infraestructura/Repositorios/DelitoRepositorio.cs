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
    /// Repositorio para la entidad Delito.
    /// </summary>
    public class DelitoRepositorio : IDelitoRepositorio
    {
        private readonly AppDbContext _context;

        public DelitoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Delito>> GetAll()
        {
            return await _context.Delitos
                .Include(d => d.TipoDelito)
                .Include(d => d.Ubicacion)
                    .ThenInclude(u => u.Barrio)
                .ToListAsync();
        }

        public async Task<Delito> GetById(int id)
        {
            return await _context.Delitos.FindAsync(id);
        }
    }
}
