using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly SqlContext sqlContext;

        public CategoriaRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
