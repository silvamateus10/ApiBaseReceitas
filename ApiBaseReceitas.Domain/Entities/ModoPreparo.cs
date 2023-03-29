using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_modo_preparo")]
    public class ModoPreparo
    {
        [Key]
        [Column("id_modo_preparo")]
        public int IdModoPreparo { get; set; } 

        [Column("nm_modo_preparo")]
        public string? NomeModoPreparo { get; set; } 

        [Column("id_receita")]
        public int IdReceita { get; set; }

        [ForeignKey("IdReceita")]
        public Receita? Receita { get; set; }
    }
}
