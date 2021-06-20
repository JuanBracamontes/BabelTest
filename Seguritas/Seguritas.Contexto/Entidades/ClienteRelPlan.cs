using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguritasModel.Entidades
{
    [Table(@"ClienteRelPlan")]
    public class ClienteRelPlan
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int PlanId { get; set; }

    }
}
