using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IMontagemApplication
    {
        MontagemDTO Add(MontagemDTO montagemDTO);
        MontagemDTO Update(MontagemDTO montagemDTO);
        MontagemDTO Remove(int id);
        IEnumerable<MontagemDTO> GetAll();
        MontagemDTO GetById(int id);
    }
}
