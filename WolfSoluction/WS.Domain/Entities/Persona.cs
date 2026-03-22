using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Domain.Entities
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Codigo_Persona { get; set; }
        public char TipoPersona { get; set; }
        public string Identificacion { get; set; }
        public string Nombre_RazonSocial { get; set; }
        public string Direccion { get; set; }
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; } = DateTime.Now;
    }
}
