using System;
using System.Collections.Generic;
using System.Text;
using WS.Domain.Entities;

namespace WS.Domain.Interface
{
    public interface IEstadoRepository
    {
        Task<IEnumerable<Estado>> ListarEstadoAsync();
        Task NuevoEstadoAsync(Estado estado);
        Task EditarEstadoAsync(Estado estado);
      
    }
}
