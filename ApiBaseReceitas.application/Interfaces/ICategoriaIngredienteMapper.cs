using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface ICategoriaIngredienteMapper
    {
        CategoriaIngrediente MapperDtoToEntity(CategoriaIngredienteDTO categoriaIngredienteDTO);
        IEnumerable<CategoriaIngredienteDTO> MapperLitsClienteDto(IEnumerable<CategoriaIngrediente> categoriasIngredientes);
        CategoriaIngredienteDTO MapperEntityToDto(CategoriaIngrediente categoriaIngrediente);
    }
}
