using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class CategoriaIngredienteDtoToModelMapping : Profile
    {
        public CategoriaIngredienteDtoToModelMapping()
        {
            CategoriaIngredienteMap();
        }

        private void CategoriaIngredienteMap()
        {
            CreateMap<CategoriaIngredienteDTO, CategoriaIngrediente>()
                .ForMember(dest => dest.IdCategoriaIngrediente, opt => opt.MapFrom(x => x.IdCategoriaIngrediente))
                .ForMember(dest => dest.NomeCategoriaIngrediente, opt => opt.MapFrom(x => x.NomeCategoriaIngrediente))
                .ForMember(dest => dest.Ingredientes, opt => opt.MapFrom(x => x.Ingredientes));

        }
    }
}