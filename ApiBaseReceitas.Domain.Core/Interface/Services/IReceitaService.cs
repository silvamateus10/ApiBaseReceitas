using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Domain.Core.Interface.Services
{
    public interface IReceitaService : IBaseService<Receita>
    {
        IEnumerable<Receita> ObterTodos();
        Receita ObterPorId(int id);
    }
}
