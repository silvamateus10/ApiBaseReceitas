using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface IIngredienteApplication
    {
        IngredienteDTO Add(IngredienteDTO ingredienteDTO);
        IngredienteDTO Update(IngredienteDTO ingredienteDTO);
        IngredienteDTO Remove(int id);
        IEnumerable<IngredienteDTO> GetAll();
        IngredienteDTO GetById(int id);
    }
}
