using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.Domain.Service
{
    public class CategoriaService : BaseService<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository categoriaRepository;
        
        public CategoriaService(ICategoriaRepository categoriaRepository)
            :base(categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }
    }
}
