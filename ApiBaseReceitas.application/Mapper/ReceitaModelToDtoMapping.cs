using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class ReceitaModelToDtoMapping : Profile
    {
        public ReceitaModelToDtoMapping()
        {
            ReceitaDTOMap();
        }

        private void ReceitaDTOMap()
        {
            CreateMap<Receita, ReceitaDTO>()
                .ForMember(dest => dest.IdReceita, opt => opt.MapFrom(x => x.IdReceita))
                .ForMember(dest => dest.NomeReceita, opt => opt.MapFrom(x => x.NomeReceita))                
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(x => x.IdCategoria))
                .ForMember(dest => dest.Categoria, opt => opt.MapFrom(x => x.Categoria))
                .ForMember(dest => dest.Ingredientes, opt => opt.MapFrom(x => x.Ingredientes));
        }
    }
}
