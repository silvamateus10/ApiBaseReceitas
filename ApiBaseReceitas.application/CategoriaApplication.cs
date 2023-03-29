using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class CategoriaApplication : ICategoriaApplication
    {
        private readonly ICategoriaService categoriaService;
        private readonly IMapper mapper;

        public CategoriaApplication(ICategoriaService categoriaService, IMapper mapper)
        {
            this.categoriaService = categoriaService;
            this.mapper = mapper;
        }

        public CategoriaDTO Add(CategoriaDTO categoriaDTO)
        {
            var categoria = mapper.Map<Categoria>(categoriaDTO);
            var retorno = categoriaService.Add(categoria);
            return mapper.Map<CategoriaDTO>(retorno);
        }

        public IEnumerable<CategoriaDTO> GetAll()
        {
            var categorias = categoriaService.GetAll();
            var categoriaDTO = mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
            return categoriaDTO;
        }

        public CategoriaDTO GetById(int id)
        {
            var categoria = categoriaService.GetById(id);
            var categoriaDTO = mapper.Map<CategoriaDTO>(categoria);
            return categoriaDTO;
        }

        public CategoriaDTO Remove(int id)
        {            
            var retorno = categoriaService.Remove(id);
            return mapper.Map<CategoriaDTO>(retorno);
        }

        public CategoriaDTO Update(CategoriaDTO categoriaDTO)
        {
            var categoria = mapper.Map<Categoria>(categoriaDTO);
            var retorno =  categoriaService.Update(categoria);
            return mapper.Map<CategoriaDTO>(retorno);
        }
    }
}
