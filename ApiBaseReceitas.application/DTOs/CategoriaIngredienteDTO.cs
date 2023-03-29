using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBaseReceitas.application.DTOs
{
    public class CategoriaIngredienteDTO
    {
        public int IdCategoriaIngrediente { get; set; }        
        public string? NomeCategoriaIngrediente { get; set; }
        public IEnumerable<IngredienteDTO>? Ingredientes { get; set; }
    }
}
