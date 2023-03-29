using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class ModoPreparoDtoToModelMapping : Profile
    {
        public ModoPreparoDtoToModelMapping()
        {
            ModoPreparoMap();
        }

        private void ModoPreparoMap()
        {
            CreateMap<ModoPreparoDTO, ModoPreparo>()
                .ForMember(dest => dest.IdModoPreparo, opt => opt.MapFrom(x => x.IdModoPreparo))
                .ForMember(dest => dest.NomeModoPreparo, opt => opt.MapFrom(x => x.NomeModoPreparo))
                .ForMember(dest => dest.IdReceita, opt => opt.MapFrom(x => x.IdReceita));                

        }
    }
}
