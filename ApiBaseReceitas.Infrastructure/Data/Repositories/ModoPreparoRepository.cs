using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class ModoPreparoRepository : BaseRepository<ModoPreparo>, IModoPreparoRepository
    {
        private readonly SqlContext sqlContext;

        public ModoPreparoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
