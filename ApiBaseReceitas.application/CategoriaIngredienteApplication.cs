using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class CategoriaIngredienteApplication : ICategoriaIngredienteApplication
    {
        private readonly ICategoriaIngredienteService categoriaIngredienteService;
        private readonly IMapper mapper;
            
        public CategoriaIngredienteApplication(ICategoriaIngredienteService categoriaIngredienteService, IMapper mapper)
        {
            this.categoriaIngredienteService = categoriaIngredienteService;
            this.mapper = mapper;
        }

        public CategoriaIngredienteDTO Add(CategoriaIngredienteDTO categoriaIngredienteDTO)
        {
            var categoriaIngrediente = mapper.Map<CategoriaIngrediente>(categoriaIngredienteDTO);
            var retorno = categoriaIngredienteService.Add(categoriaIngrediente);
            return mapper.Map<CategoriaIngredienteDTO>(retorno);
        }

        public IEnumerable<CategoriaIngredienteDTO> GetAll()
        {
            var categoriaIngrediente = categoriaIngredienteService.GetAll();
            var categoriaIngredienteDTO = mapper.Map<IEnumerable<CategoriaIngredienteDTO>>(categoriaIngrediente);
            return categoriaIngredienteDTO;
        }

        public CategoriaIngredienteDTO GetById(int id)
        {
            var categoriaIngrediente = categoriaIngredienteService.GetById(id);
            var categoriaIngredienteDTO = mapper.Map<CategoriaIngredienteDTO>(categoriaIngrediente);
            return categoriaIngredienteDTO;
        }

        public CategoriaIngredienteDTO Remove(int id)
        {
            var retorno =  categoriaIngredienteService.Remove(id);
            return mapper.Map<CategoriaIngredienteDTO>(retorno);
        }

        public CategoriaIngredienteDTO Update(CategoriaIngredienteDTO categoriaIngredienteDTO)
        {
            var categoriaIngrediente = mapper.Map<CategoriaIngrediente>(categoriaIngredienteDTO);
            var retorno =  categoriaIngredienteService.Update(categoriaIngrediente);
            return mapper.Map<CategoriaIngredienteDTO>(retorno);
        }
    }
}
