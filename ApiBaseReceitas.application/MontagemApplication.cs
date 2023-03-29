using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class MontagemApplication : IMontagemApplication
    {
        private readonly IMontagemService montagemService;
        private readonly IMapper mapper;

        public MontagemApplication(IMontagemService montagemService, IMapper mapper)
        {
            this.montagemService = montagemService;
            this.mapper = mapper;
        }

        public MontagemDTO Add(MontagemDTO montagemDTO)
        {
            var montagem = mapper.Map<Montagem>(montagemDTO);
            var retorno = montagemService.Add(montagem);
            return mapper.Map<MontagemDTO>(retorno);
        }

        public IEnumerable<MontagemDTO> GetAll()
        {
            var montagens = montagemService.GetAll();
            var montagemDTO = mapper.Map<IEnumerable<MontagemDTO>>(montagens);
            return montagemDTO;
        }

        public MontagemDTO GetById(int id)
        {
            var montagem = montagemService.GetById(id);
            var montagemDTO = mapper.Map<MontagemDTO>(montagem);
            return montagemDTO;
        }

        public MontagemDTO Remove(int id)
        {
            var retorno = montagemService.Remove(id);
            return mapper.Map<MontagemDTO>(retorno);
        }

        public MontagemDTO Update(MontagemDTO montagemDTO)
        {
            var montagem = mapper.Map<Montagem>(montagemDTO);
            var retorno = montagemService.Update(montagem);
            return mapper.Map<MontagemDTO>(retorno);
        }
    }
}
