using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class CategoriaDtoToModelMapping : Profile
    {
        public CategoriaDtoToModelMapping()
        {
            CategoriaMap();
        }

        private void CategoriaMap()
        {
            CreateMap<CategoriaDTO, Categoria>()
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(x => x.IdCategoria))
                .ForMember(dest => dest.NomeCategoria, opt => opt.MapFrom(x => x.NomeCategoria))
                .ForMember(dest => dest.Receitas, opt => opt.MapFrom(x => x.Receitas));

        }
    }
}
