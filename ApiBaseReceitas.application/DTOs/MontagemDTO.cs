namespace ApiBaseReceitas.application.DTOs
{
    public class MontagemDTO
    {
        public int IdMontagem { get; set; }        
        public string? NomeMontagem { get; set; }      
        public int IdReceita { get; set; }
        public ReceitaDTO? Receita { get; set; }
    }
}
