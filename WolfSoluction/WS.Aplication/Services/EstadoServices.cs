using System;
using System.Collections.Generic;
using System.Text;
using WS.Domain.DTOs;
using WS.Domain.Entities;
using WS.Domain.Interface;

namespace WS.Aplication.Services
{
    public class EstadoServices
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoServices(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public async Task<IEnumerable<EstadoDTOs>> ListarEstado()
        {

            var lista = await _estadoRepository.ListarEstadoAsync();

            return lista.Select(E => new EstadoDTOs
            {
                IdEstado = E.IdEstado,
                TipoEstado = E.TipoEstado,
                FechaIngreso = E.FechaIngreso,
            });
        }

        public async Task NuevoEstado(EstadoDTOs estadoDTOs)
        {
            var oEstado = new Estado
            {
                TipoEstado = estadoDTOs.TipoEstado,
                FechaIngreso = estadoDTOs.FechaIngreso,
            };
        }

        public async Task EditarEstado(EstadoDTOs estadoDTOs)
        {

        }
    }
}
