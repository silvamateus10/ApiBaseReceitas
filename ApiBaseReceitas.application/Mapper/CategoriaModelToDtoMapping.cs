using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class CategoriaModelToDtoMapping : Profile
    {
        public CategoriaModelToDtoMapping()
        {
            CategoriaDTOMap();
        }

        private void CategoriaDTOMap()
        {
            CreateMap<Categoria, CategoriaDTO>()
                .ForMember(dest => dest.IdCategoria, opt => opt.MapFrom(x => x.IdCategoria))
                .ForMember(dest => dest.NomeCategoria, opt => opt.MapFrom(x => x.NomeCategoria))
                .ForMember(dest => dest.Receitas, opt => opt.MapFrom(x => x.Receitas));
        }
    }
}
