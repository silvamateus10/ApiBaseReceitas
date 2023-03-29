namespace ApiBaseReceitas.application.DTOs
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        public string? NomeCategoria { get; set; }
        public IEnumerable<ReceitaDTO>? Receitas { get; set; }

    }
}
