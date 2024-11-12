using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcetas.Models
{
    public class IngredienteReceta
    {
        [Key]
        public long Id { get; set; }

        public long Cantidad { get; set; }

        [ForeignKey("Receta")]
        public long RecetaId { get; set; }

        [ForeignKey("Ingrediente")]
        public long IngredienteId { get; set; }

        public bool Estatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Receta Receta { get; set; }

        // Relación muchos a uno con Ingrediente
        public Ingrediente Ingrediente { get; set; }
    }
}
