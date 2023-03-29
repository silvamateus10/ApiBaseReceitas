using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IMontagemMapper
    {
        Montagem MapperDtoToEntity(MontagemDTO montagemDTO);
        IEnumerable<MontagemDTO> MapperLitsClienteDto(IEnumerable<Montagem> montagens);
        MontagemDTO MapperEntityToDto(Montagem montagem);
    }
}
