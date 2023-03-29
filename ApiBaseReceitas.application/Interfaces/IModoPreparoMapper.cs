using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IModoPreparoMapper
    {
        ModoPreparo MapperDtoToEntity(ModoPreparoDTO modoPreparoDTO);
        IEnumerable<ModoPreparoDTO> MapperLitsClienteDto(IEnumerable<ModoPreparo> modosPreparos);
        ModoPreparoDTO MapperEntityToDto(ModoPreparo modoPreparo);
    }
}
