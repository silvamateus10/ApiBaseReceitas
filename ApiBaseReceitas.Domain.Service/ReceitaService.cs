using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Domain.Service
{
    public class ReceitaService : BaseService<Receita>, IReceitaService
    {
        private readonly IReceitaRepository receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository)
            : base(receitaRepository)
        {
            this.receitaRepository = receitaRepository;
        }

        public Receita ObterPorId(int id)
        {
            return receitaRepository.ObterPorId(id);
        }

        public IEnumerable<Receita> ObterTodos()
        {
            return receitaRepository.ObterTodos();
        }

    }
}
