using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;

namespace ApiBaseReceitas.Domain.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;
        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            return repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public TEntity Remove(int id)
        {
            //Transformando em objeto para apagar pelo Entity
            var obj = GetById(id);
            return repository.Remove(obj);
        }

        public TEntity Update(TEntity obj)
        {
            return repository.Update(obj);
        }
    }
}
