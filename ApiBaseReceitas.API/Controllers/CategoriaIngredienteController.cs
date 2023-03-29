using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Entities;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaIngredienteController : Controller
    {
        private readonly ICategoriaIngredienteApplication categoriaIngredienteApplication;

        public CategoriaIngredienteController(ICategoriaIngredienteApplication categoriaIngredienteApplication)
        {
            this.categoriaIngredienteApplication = categoriaIngredienteApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var categoriasIngrediente = categoriaIngredienteApplication.GetAll();

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categorias dos Ingredientes.",
                    ObjetoRetorno = new ResponseObjeto<CategoriaIngredienteDTO>
                    {
                        Lista = categoriasIngrediente
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = false,
                    IsErro = true,
                    Mensagem = ex.Message,
                    ObjetoRetorno = null
                };

                return BadRequest(resposta);
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var categoriaIngrediente = categoriaIngredienteApplication.GetById(id);

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria do Ingrediente.",
                    ObjetoRetorno = new ResponseObjeto<CategoriaIngredienteDTO>
                    {
                        Objeto = categoriaIngrediente
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = false,
                    IsErro = true,
                    Mensagem = ex.Message,
                    ObjetoRetorno = null
                };

                return BadRequest(resposta);
            }
            
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CategoriaIngredienteDTO categoriaIngredienteDTO)
        {
            try
            {
                if (categoriaIngredienteDTO == null)
                    return NotFound();

                var categoriaIngrediente =  categoriaIngredienteApplication.Add(categoriaIngredienteDTO);
                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria do Ingrediente Cadastrado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaIngredienteDTO>
                    {
                        Objeto = categoriaIngrediente
                    }
                };

                return Ok(resposta);
                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = false,
                    IsErro = true,
                    Mensagem = ex.Message,
                    ObjetoRetorno = null
                };

                return BadRequest(resposta);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] CategoriaIngredienteDTO categoriaIngredienteDTO)
        {
            try
            {
                if (categoriaIngredienteDTO == null)
                    return NotFound();

                var categoriaIngrediente = categoriaIngredienteApplication.Update(categoriaIngredienteDTO);
                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria do Ingrediente Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaIngredienteDTO>
                    {
                        Objeto = categoriaIngrediente
                    }
                };

                return Ok(resposta);
                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = false,
                    IsErro = true,
                    Mensagem = ex.Message,
                    ObjetoRetorno = null
                };

                return BadRequest(resposta);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var categoriaIngrediente = categoriaIngredienteApplication.Remove(id);
                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria do Ingrediente Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaIngredienteDTO>
                    {
                        Objeto = categoriaIngrediente
                    }
                };

                return Ok(resposta);
                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaIngredienteDTO>
                {
                    IsOk = false,
                    IsErro = true,
                    Mensagem = ex.Message,
                    ObjetoRetorno = null
                };

                return BadRequest(resposta);
            }

        }
    }
}
