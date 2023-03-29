using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.Domain.Entities
{
    [Table("t_montagem")]
    public class Montagem
    {
        [Key]
        [Column("id_montagem")]
        public int IdMontagem { get; set; }

        [Column("nm_montagem")]
        public string? NomeMontagem { get; set; }

        [Column("id_receita")]
        public int IdReceita { get; set; }

        [ForeignKey("IdReceita")]       
        public Receita? Receita { get; set; }    

    }
}
