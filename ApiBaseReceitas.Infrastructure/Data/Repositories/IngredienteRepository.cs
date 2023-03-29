using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class IngredienteRepository : BaseRepository<Ingrediente>, IIngredienteRepository
    {
        private readonly SqlContext sqlContext;

        public IngredienteRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
