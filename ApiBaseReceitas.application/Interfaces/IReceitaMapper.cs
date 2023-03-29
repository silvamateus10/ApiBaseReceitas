using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.Domain.Entities;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IReceitaMapper
    {
        Receita MapperDtoToEntity(ReceitaDTO receitaDTO);
        IEnumerable<ReceitaDTO> MapperLitsClienteDto(IEnumerable<Receita> receitas);
        ReceitaDTO MapperEntityToDto(Receita receita);
    }
}
