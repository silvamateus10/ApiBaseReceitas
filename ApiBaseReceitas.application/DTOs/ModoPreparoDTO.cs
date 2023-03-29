using ApiBaseReceitas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBaseReceitas.application.DTOs
{
    public class ModoPreparoDTO
    {
        public int IdModoPreparo { get; set; }        
        public string? NomeModoPreparo { get; set; }        
        public int IdReceita { get; set; }
        public ReceitaDTO? Receita { get; set; }
    }
}
