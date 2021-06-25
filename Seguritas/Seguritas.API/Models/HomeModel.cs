using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguritas.API.Models
{
    public class HomeModel
    {
        #region Clientes section
        //Clientes section
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteFechaCreacion { get; set; }
        public string ClienteFechaModificacion { get; set; }
        #endregion
        #region Planes section
        //Planes section
        public int PlanId { get; set; }
        public string PlanNombre { get; set; }
        public string PlanFechaCreacion { get; set; }
        public string PlanFechaModificacion { get; set; }
        #endregion
        #region Coberturas section
        //Coberturas section
        public int CoberturaId { get; set; }
        public string CoberturaNombre { get; set; }
        public string CoberturaFechaCreacion { get; set; }
        public string CoberturaFechaModificacion { get; set; }
        #endregion
    }
}
