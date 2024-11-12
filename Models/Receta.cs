using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcetas.Models
{
    public class Receta
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public bool Estatus { get; set; } // Representa activo/inactivo (1/0)

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        // Relación uno a muchos con IngredienteReceta
        public ICollection<IngredienteReceta> IngredientesReceta { get; set; }
    }
}
