using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IIngredienteMapper
    {
        Ingrediente MapperDtoToEntity(IngredienteDTO ingredienteDTO);
        IEnumerable<IngredienteDTO> MapperLitsClienteDto(IEnumerable<Ingrediente> ingredientes);
        IngredienteDTO MapperEntityToDto(Ingrediente ingrediente);
    }
}
