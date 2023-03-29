using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_categoria_ingrediente")]
    public class CategoriaIngrediente
    {
        [Key]
        [Column("id_categoria_ingrediente")]
        public int IdCategoriaIngrediente { get; set; }

        [Column("nm_categoria_ingrediente")]
        public string? NomeCategoriaIngrediente { get; set; }

        public IEnumerable<Ingrediente>? Ingredientes { get; set; }
        
    }
}
