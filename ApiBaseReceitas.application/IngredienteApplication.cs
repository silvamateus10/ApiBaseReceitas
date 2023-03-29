using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class IngredienteApplication : IIngredienteApplication
    {
        private readonly IIngredienteService ingredienteService;
        private readonly IMapper mapper;

        public IngredienteApplication(IIngredienteService ingredienteService, IMapper mapper)
        {
            this.ingredienteService = ingredienteService;
            this.mapper = mapper;
        }

        public IngredienteDTO Add(IngredienteDTO ingredienteDTO)
        {
            var ingrediente = mapper.Map<Ingrediente>(ingredienteDTO);
            var retorno = ingredienteService.Add(ingrediente);
            return mapper.Map<IngredienteDTO>(retorno);
        }

        public IEnumerable<IngredienteDTO> GetAll()
        {
            var ingredientes = ingredienteService.GetAll();
            var ingredienteDTO = mapper.Map<IEnumerable<IngredienteDTO>>(ingredientes);
            return ingredienteDTO;
        }

        public IngredienteDTO GetById(int id)
        {
            var ingrediente = ingredienteService.GetById(id);
            var ingredienteDTO = mapper.Map<IngredienteDTO>(ingrediente);
            return ingredienteDTO;
        }

        public IngredienteDTO Remove(int id)
        {
            var retorno =  ingredienteService.Remove(id);
            return mapper.Map<IngredienteDTO>(retorno);
        }

        public IngredienteDTO Update(IngredienteDTO ingredienteDTO)
        {
            var ingrediente = mapper.Map<Ingrediente>(ingredienteDTO);
            var retorno = ingredienteService.Update(ingrediente);
            return mapper.Map<IngredienteDTO>(retorno);
        }
    }
}
