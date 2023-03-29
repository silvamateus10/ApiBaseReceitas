using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface ICategoriaMapper
    {
        Categoria MapperDtoToEntity(CategoriaDTO categoriaDTO);
        IEnumerable<CategoriaDTO> MapperLitsClienteDto(IEnumerable<Categoria> categorias);
        CategoriaDTO MapperEntityToDto(Categoria categoria);
    }
}
