using ApiBaseReceitas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBaseReceitas.application.DTOs
{
    public class ReceitaDTO
    {
        public int IdReceita { get; set; }

        public string? NomeReceita { get; set; }
               
        public int IdCategoria { get; set; }
        public Categoria? Categoria { get; set; }

        public IEnumerable<IngredienteDTO>? Ingredientes { get; set; }        
    }
}
