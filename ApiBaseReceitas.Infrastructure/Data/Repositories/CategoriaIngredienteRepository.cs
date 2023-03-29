using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class CategoriaIngredienteRepository : BaseRepository<CategoriaIngrediente>, ICategoriaIngredienteRepository
    {
        private readonly SqlContext sqlContext;

        public CategoriaIngredienteRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }


    }
}
