namespace Infraestructura.Repositorios
{
    using Dominio.Entidades;
    using Dominio.Interfaces;
    using Infraestructura.Data;
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

    public class UbicacionRepositorio : IUbicacionRepositorio
    {
        private readonly AppDbContext _context;

        public UbicacionRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ubicacion>> GetAll()
        {
            return await _context.Ubicaciones
                .Include(u => u.Barrio)
                .Include(u => u.Localidad)
                .ToListAsync();
        }

        public async Task<Ubicacion> GetById(int id)
        {
            return await _context.Ubicaciones.FindAsync(id);
        }

        public async Task<IEnumerable<Ubicacion>> GetByBarrio(int barrioId)
        {
            return await _context.Ubicaciones
                .Where(u => u.BarrioId == barrioId)
                .ToListAsync();
        }

        public async Task Update(Ubicacion ubicacion)
        {
            _context.Ubicaciones.Update(ubicacion);
            await _context.SaveChangesAsync();
        }
    }
}
