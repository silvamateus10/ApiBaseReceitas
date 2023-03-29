using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_ingrediente")]
    public class Ingrediente
    {
        [Key]
        [Column("id_ingrediente")]
        public int IdIngrediente { get; set; }

        [Column("nm_ingrediente")]
        public string? NomeIngrediente { get; set; }

        [Column("id_receita")]
        public int IdReceita { get; set; }

        [Column("id_categoria_ingrediente")]
        public int IdCategoriaIngrediente { get; set; }

        [ForeignKey("IdReceita")]
        public Receita? Receita { get; set; }

        [ForeignKey("IdCategoriaIngrediente")]
        public CategoriaIngrediente? CategoriaIngrediente { get; set; }
    }
}
