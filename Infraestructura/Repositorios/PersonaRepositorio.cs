namespace Infraestructura.Repositorios
{
    using Dominio.Entidades;
    using Dominio.Interfaces;
    using Infraestructura.Data;
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Repositorio para la entidad Persona.
    /// </summary>
    public class PersonaRepositorio : IPersonaRepositorio
    {

        private readonly AppDbContext _context;

        public PersonaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await _context.Personas.ToListAsync();
        }

        public async Task<Persona> GetById(int id)
        {
            return await _context.Personas.FindAsync(id);
        }

        public async Task Add(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Persona persona)
        {
            _context.Personas.Update(persona);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
        }
    }
}
