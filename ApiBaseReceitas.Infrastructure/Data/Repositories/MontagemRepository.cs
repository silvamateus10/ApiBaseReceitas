using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class MontagemRepository : BaseRepository<Montagem>, IMontagemRepository
    {
        private readonly SqlContext sqlContext;

        public MontagemRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
