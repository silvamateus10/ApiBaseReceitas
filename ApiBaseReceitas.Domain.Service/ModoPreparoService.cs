using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBaseReceitas.Domain.Service
{
    public class ModoPreparoService : BaseService<ModoPreparo>, IModoPreparoService
    {
        private readonly IModoPreparoRepository modoPreparoRepository;

        public ModoPreparoService(IModoPreparoRepository modoPreparoRepository)
            : base(modoPreparoRepository)
        {
            this.modoPreparoRepository = modoPreparoRepository;
        }
    }
}
