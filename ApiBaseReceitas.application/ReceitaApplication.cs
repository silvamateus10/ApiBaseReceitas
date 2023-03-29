using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class ReceitaApplication : IReceitaApplication
    {

        private readonly IReceitaService receitaService;
        private readonly IMapper mapper;

        public ReceitaApplication(IReceitaService receitaService, IMapper mapper)
        {
            this.receitaService = receitaService;
            this.mapper = mapper;
        }

        public ReceitaDTO Add(ReceitaDTO receitaDTO)
        {
            var receita = mapper.Map<Receita>(receitaDTO);
            var retorno = receitaService.Add(receita);
            return mapper.Map<ReceitaDTO>(retorno);
        }

        public IEnumerable<ReceitaDTO> GetAll()
        {
            var receitas = receitaService.GetAll();
            var receitaDTO = mapper.Map<IEnumerable<ReceitaDTO>>(receitas);
            return receitaDTO;
        }

        public ReceitaDTO GetById(int id)
        {
            var receita = receitaService.GetById(id);
            var receitaDTO = mapper.Map<ReceitaDTO>(receita);
            return receitaDTO;
        }

        public ReceitaDTO Remove(int id)
        {
            var retorno = receitaService.Remove(id);
            return mapper.Map<ReceitaDTO>(retorno);
        }

        public ReceitaDTO Update(ReceitaDTO receitaDTO)
        {
            var receita = mapper.Map<Receita>(receitaDTO);
            var retorno = receitaService.Update(receita);
            return mapper.Map<ReceitaDTO>(retorno);
        }
    }
}
