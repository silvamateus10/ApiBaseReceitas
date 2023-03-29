using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class MontagemDtoToModelMapping : Profile
    {
        public MontagemDtoToModelMapping()
        {
            MontagemMap();
        }

        private void MontagemMap()
        {
            CreateMap<MontagemDTO, Montagem>()
                .ForMember(dest => dest.IdMontagem, opt => opt.MapFrom(x => x.IdMontagem))
                .ForMember(dest => dest.NomeMontagem, opt => opt.MapFrom(x => x.NomeMontagem))
                .ForMember(dest => dest.IdReceita, opt => opt.MapFrom(x => x.IdReceita))
                .ForMember(dest => dest.Receita, opt => opt.MapFrom(x => x.Receita));

        }
    }
}
