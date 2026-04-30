namespace Aplicación.Servicios
{
    using Aplicación.DTOs;
    using Aplicación.Interfaces;
    using Dominio.Entidades;
    using Dominio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Servicio para la gestión de personas.
    /// </summary>
    public class PersonaServicio : IPersonaServicio
    {
        private readonly IPersonaRepositorio _repo;

        public PersonaServicio(IPersonaRepositorio repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<PersonaDTO>> GetAll()
        {
            var personas = await _repo.GetAll();
            return personas.Select(p => new PersonaDTO
            {
                Id = p.Id,
                NombreCompleto = $"{p.Nombre} {p.Apellido}",
                Edad = p.Edad,
            });
        }

        public async Task Add(PersonaDTO persona)
        {
            var nuevaPersona = new Persona
            {
                Nombre = persona.NombreCompleto.Split(' ')[0],
                Apellido = persona.NombreCompleto.Split(' ')[1],
                Edad = persona.Edad
            };

            await _repo.Add(nuevaPersona);
        }
    }
}
