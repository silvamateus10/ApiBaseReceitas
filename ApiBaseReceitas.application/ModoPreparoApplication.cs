using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application
{
    public class ModoPreparoApplication : IModoPreparoApplication
    {
        private readonly IModoPreparoService modoPreparoService;
        private readonly IMapper mapper;

        public ModoPreparoApplication(IModoPreparoService modoPreparoService, IMapper mapper)
        {
            this.modoPreparoService = modoPreparoService;
            this.mapper = mapper;
        }

        public ModoPreparoDTO Add(ModoPreparoDTO modoPreparoDTO)
        {
            var modoPreparo = mapper.Map<ModoPreparo>(modoPreparoDTO);
            var retorno = modoPreparoService.Add(modoPreparo);
            return mapper.Map<ModoPreparoDTO>(retorno);
        }

        public IEnumerable<ModoPreparoDTO> GetAll()
        {
            var modosPreparos = modoPreparoService.GetAll();
            var modoPreparoDTO = mapper.Map<IEnumerable<ModoPreparoDTO>>(modosPreparos);
            return modoPreparoDTO;
        }

        public ModoPreparoDTO GetById(int id)
        {
            var modoPreparo = modoPreparoService.GetById(id);
            var modoPreparoDTO = mapper.Map<ModoPreparoDTO>(modoPreparo);
            return modoPreparoDTO;
        }

        public ModoPreparoDTO Remove(int id)
        {
            var retorno = modoPreparoService.Remove(id);
            return mapper.Map<ModoPreparoDTO>(retorno);
        }

        public ModoPreparoDTO Update(ModoPreparoDTO modoPreparoDTO)
        {
            var modoPreparo = mapper.Map<ModoPreparo>(modoPreparoDTO);
            var retorno = modoPreparoService.Update(modoPreparo);
            return mapper.Map<ModoPreparoDTO>(retorno);
        }
    }
}
