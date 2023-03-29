using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class CategoriaIngredienteModelToDtoMapping : Profile
    {
        public CategoriaIngredienteModelToDtoMapping()
        {
            CategoriaIngredienteDTOMap();
        }

        private void CategoriaIngredienteDTOMap()
        {
            CreateMap<CategoriaIngrediente, CategoriaIngredienteDTO>()
                .ForMember(dest => dest.IdCategoriaIngrediente, opt => opt.MapFrom(x => x.IdCategoriaIngrediente))
                .ForMember(dest => dest.NomeCategoriaIngrediente, opt => opt.MapFrom(x => x.NomeCategoriaIngrediente))
                .ForMember(dest => dest.Ingredientes, opt => opt.MapFrom(x => x.Ingredientes));
        }
    }
}
