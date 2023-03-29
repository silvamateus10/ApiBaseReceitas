namespace ApiBaseReceitas.Domain.Core.Interface.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Remove(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
