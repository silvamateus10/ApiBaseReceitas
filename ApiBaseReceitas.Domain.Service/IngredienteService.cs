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
    public class IngredienteService : BaseService<Ingrediente>, IIngredienteService
    {
        private readonly IIngredienteRepository ingredienteRepository;

        public IngredienteService(IIngredienteRepository ingredienteRepository)
            : base(ingredienteRepository)
        {
            this.ingredienteRepository = ingredienteRepository;
        }
    }
}
