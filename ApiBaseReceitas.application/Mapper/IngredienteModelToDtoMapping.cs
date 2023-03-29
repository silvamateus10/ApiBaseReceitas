using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;
using AutoMapper;

namespace ApiBaseReceitas.application.Mapper
{
    public class IngredienteModelToDtoMapping : Profile
    {
        public IngredienteModelToDtoMapping()
        {
            IngredienteDTOMap();
        }

        private void IngredienteDTOMap()
        {
            CreateMap<Ingrediente, IngredienteDTO>()
                .ForMember(dest => dest.IdIngrediente, opt => opt.MapFrom(x => x.IdIngrediente))
                .ForMember(dest => dest.NomeIngrediente, opt => opt.MapFrom(x => x.NomeIngrediente))
                .ForMember(dest => dest.IdReceita, opt => opt.MapFrom(x => x.IdReceita))
                .ForMember(dest => dest.IdCategoriaIngrediente, opt => opt.MapFrom(x => x.IdCategoriaIngrediente))
                .ForMember(dest => dest.Receita, opt => opt.MapFrom(x => x.Receita))
                .ForMember(dest => dest.CategoriaIngrediente, opt => opt.MapFrom(x => x.CategoriaIngrediente));
        }
    }
}
