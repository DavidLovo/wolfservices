using System;
using System.Collections.Generic;
using System.Text;
using WS.Domain.Entities;

namespace WS.Domain.Interface
{
    public interface ICorreoRespository
    {
        Task<IEnumerable<Correo>> ListarCorreoAsync();
        Task NuevoCorreoAsync(Correo ocorreo);
        Task EditarCorreoAsync(Correo ocorreo);
        Task CambiarEstadoCorreoAsyc(Correo ocorreo);


    }
}
