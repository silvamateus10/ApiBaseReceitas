using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Domain.Service
{
    public class MontagemService : BaseService<Montagem>, IMontagemService
    {
        private readonly IMontagemRepository montagemRepository;

        public MontagemService(IMontagemRepository montagemRepository)
            : base(montagemRepository)
        {
            this.montagemRepository = montagemRepository;
        }
    }
}
