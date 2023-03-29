namespace ApiBaseReceitas.Domain.Core.Interface.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
