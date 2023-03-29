using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_categoria")]
    public class Categoria
    {
         [Key]
         [Column("id_categoria")]
         public int IdCategoria { get; set; }   


         [Column("nm_categoria")]
         public string? NomeCategoria { get; set; }
         
         public IEnumerable<Receita>? Receitas { get; set; }

    }
}
