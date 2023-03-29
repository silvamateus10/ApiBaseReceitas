using Dapper;
using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBaseReceitas.Infrastructure.Data.Repositories
{
    public class ReceitaRepository : BaseRepository<Receita>, IReceitaRepository
    {
        private readonly SqlContext sqlContext;

        public ReceitaRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public IEnumerable<Receita> ObterTodos()
        {
            using (var connection = sqlContext.Database.GetDbConnection())
            {
                connection.Open();
                var sql = @"select 
	                            IdReceita = tr.id_receita
	                            ,NomeReceita = tr.nm_receita
	                            ,IdCategoria = tr.id_categoria
                            from t_receita tr";
                return connection.Query<Receita>(sql);
            }
        }

        public Receita ObterPorId(int id)
        {
            using (var connection = sqlContext.Database.GetDbConnection())
            {
                connection.Open();
                var sql = @"select 
	                            IdReceita = tr.id_receita
	                            ,NomeReceita = tr.nm_receita
	                            ,IdCategoria = tr.id_categoria
                            from t_receita tr
                            where tr.id_receita = @id";
                return connection.QuerySingleOrDefault<Receita>(sql, new { id });
            }
        }
    }
}
