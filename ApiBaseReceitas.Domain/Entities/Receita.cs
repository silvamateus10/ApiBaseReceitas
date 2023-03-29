using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_receita")]
    public class Receita
    {
        [Key]
        [Column("id_receita")]
        public int IdReceita { get; set; }

        [Column("nm_receita")]
        public string? NomeReceita { get; set; }


        [Column("id_categoria")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria? Categoria { get; set; }

        public IEnumerable<Ingrediente>? Ingredientes { get; set; }        

    }
}
