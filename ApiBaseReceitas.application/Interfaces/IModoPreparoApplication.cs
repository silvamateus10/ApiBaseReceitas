using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IModoPreparoApplication
    {
        ModoPreparoDTO Add(ModoPreparoDTO modoPreparoDTO);
        ModoPreparoDTO Update(ModoPreparoDTO modoPreparoDTO);
        ModoPreparoDTO Remove(int id);
        IEnumerable<ModoPreparoDTO> GetAll();
        ModoPreparoDTO GetById(int id);
    }
}
