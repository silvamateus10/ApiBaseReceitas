using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Domain.Core.Interface.Repositories
{
    public interface IReceitaRepository : IBaseRepository<Receita>
    {
        IEnumerable<Receita> ObterTodos();
        Receita ObterPorId(int id);
    }
}
