using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcetas.Models
{
    public class Unidad
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public bool Estatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
