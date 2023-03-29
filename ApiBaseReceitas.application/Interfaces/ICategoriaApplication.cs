using ApiBaseReceitas.application.DTOs;

namespace ApiBaseReceitas.application.Interfaces
{
    public interface ICategoriaApplication
    {
        CategoriaDTO Add(CategoriaDTO categoriaDTO);
        CategoriaDTO Update(CategoriaDTO categoriaDTO);
        CategoriaDTO Remove(int id);
        IEnumerable<CategoriaDTO> GetAll();
        CategoriaDTO GetById(int id);
    }
}
