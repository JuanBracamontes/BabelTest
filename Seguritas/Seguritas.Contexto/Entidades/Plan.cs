using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguritasModel.Entidades
{
    [Table(@"Plan")]
    public class Plan
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        /// <summary>
        /// Navigation Properties
        /// </summary>
        public IList<Cliente> Clientes { get; set; }
        public IList<Cobertura> Coberturas { get; set; }

    }
}
