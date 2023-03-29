using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface ICategoriaIngredienteApplication
    {
        CategoriaIngredienteDTO Add(CategoriaIngredienteDTO categoriaIngredienteDTO);
        CategoriaIngredienteDTO Update(CategoriaIngredienteDTO categoriaIngredienteDTO);
        CategoriaIngredienteDTO Remove(int id);
        IEnumerable<CategoriaIngredienteDTO> GetAll();
        CategoriaIngredienteDTO GetById(int id);
    }
}
