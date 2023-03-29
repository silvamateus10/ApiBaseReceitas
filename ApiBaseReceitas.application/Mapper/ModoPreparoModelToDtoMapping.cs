using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class ModoPreparoModelToDtoMapping : Profile
    {
        public ModoPreparoModelToDtoMapping()
        {
            ModoPreparoDTOMap();
        }

        private void ModoPreparoDTOMap()
        {
            CreateMap<ModoPreparo, ModoPreparoDTO>()
                .ForMember(dest => dest.IdModoPreparo, opt => opt.MapFrom(x => x.IdModoPreparo))
                .ForMember(dest => dest.NomeModoPreparo, opt => opt.MapFrom(x => x.NomeModoPreparo))
                .ForMember(dest => dest.IdReceita, opt => opt.MapFrom(x => x.IdReceita));
        }
    }
}
