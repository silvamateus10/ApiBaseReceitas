using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IReceitaApplication
    {
        ReceitaDTO Add(ReceitaDTO receitaDTO);
        ReceitaDTO Update(ReceitaDTO receitaDTO);
        ReceitaDTO Remove(int id);
        IEnumerable<ReceitaDTO> GetAll();
        ReceitaDTO GetById(int id);
    }
}
