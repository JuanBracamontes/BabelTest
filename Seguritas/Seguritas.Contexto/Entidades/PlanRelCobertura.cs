using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguritasModel.Entidades
{
    [Table(@"PlanRelCobertura")]
    public class PlanRelCobertura
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int CoberturaId { get; set; }
        public int PlanId { get; set; }

    }
}
