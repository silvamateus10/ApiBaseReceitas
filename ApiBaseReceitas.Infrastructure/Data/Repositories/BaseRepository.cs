using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public TEntity Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public TEntity Remove(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.Set<TEntity>().Update(obj);
                sqlContext.SaveChanges();
                return obj;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
