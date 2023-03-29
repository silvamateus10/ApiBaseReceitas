namespace ApiBaseReceitas.application.DTOs
{
    public class IngredienteDTO
    {
        public int IdIngrediente { get; set; }        
        public string? NomeIngrediente { get; set; }        
        public int IdReceita { get; set; }        
        public int IdCategoriaIngrediente { get; set; }
        public ReceitaDTO? Receita { get; set; }
        public CategoriaIngredienteDTO? CategoriaIngrediente { get; set; }
    }
}
