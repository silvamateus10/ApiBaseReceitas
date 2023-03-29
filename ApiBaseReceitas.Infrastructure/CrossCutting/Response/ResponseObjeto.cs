namespace ApiBaseReceitas.Infrastructure.CrossCutting.Response
{
    public class ResponseObjeto<TEntity>
    {
        public TEntity? Objeto { get; set; }
        public IEnumerable<TEntity>? Lista { get; set; }
    }
}
