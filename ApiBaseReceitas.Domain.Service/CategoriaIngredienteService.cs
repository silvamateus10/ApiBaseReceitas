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
    public class CategoriaIngredienteService : BaseService<CategoriaIngrediente>, ICategoriaIngredienteService
    {
        private readonly ICategoriaIngredienteRepository categoriaIngredienteRepository;

        public CategoriaIngredienteService(ICategoriaIngredienteRepository categoriaIngredienteRepository)
            : base(categoriaIngredienteRepository)
        {
            this.categoriaIngredienteRepository = categoriaIngredienteRepository;
        }
    }
}
