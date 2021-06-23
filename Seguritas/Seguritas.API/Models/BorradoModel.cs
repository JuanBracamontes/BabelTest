using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguritas.API.Models
{
    public class BorradoModel
    {
        public TipoSolicitud TipoDeSolicitud { get; set; }
        public int IdPlan { get; set; }
        public int IdCliente { get; set; }
        public int IdCobertura { get; set; }
        public bool TieneNodosHijos { get; set; }
    }
}