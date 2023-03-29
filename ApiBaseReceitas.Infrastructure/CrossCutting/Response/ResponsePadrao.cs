namespace ApiBaseReceitas.Infrastructure.CrossCutting.Response
{
    public class ResponsePadrao<TEntity>
    {
        public bool IsOk { get; set; }
        public bool IsErro { get; set; }
        public string? Mensagem { get; set; }
        public ResponseObjeto<TEntity>? ObjetoRetorno { get; set; }
    }
}
