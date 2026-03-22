using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Domain.Entities
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string TipoEstado { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
