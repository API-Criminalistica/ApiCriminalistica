namespace Aplicacion.Servicios
{
    using Aplicacion.DTOs;
    using Aplicacion.Interfaces;
    using Dominio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public class TipoDelitoServicio : ITipoDelitoServicio
    {
        private readonly ITipoDelitoRepositorio _repo;

        public TipoDelitoServicio(ITipoDelitoRepositorio repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<TipoDelitoDTO>> GetAll()
        {
            var tipos = await _repo.GetAll();
            return tipos.Select(t => new TipoDelitoDTO
            {
                Id = t.Id,
                Nombre = t.Nombre
            });
        }
    }
}
