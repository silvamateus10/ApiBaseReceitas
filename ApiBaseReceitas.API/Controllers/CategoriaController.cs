using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaApplication categoriaApplication;

        public CategoriaController(ICategoriaApplication categoriaApplication)
        {
            this.categoriaApplication = categoriaApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(bool isInclude = false)
        {
            try
            {
                var categorias = categoriaApplication.GetAll();

                if (!isInclude)
                {
                    foreach (var categoria in categorias)
                    {
                        categoria.Receitas = null;
                    }
                }

                var resposta = new ResponsePadrao<CategoriaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categorias.",
                    ObjetoRetorno = new ResponseObjeto<CategoriaDTO>
                    {
                        Lista = categorias
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaDTO>
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
        public ActionResult<string> Get(int id, bool isInclude = false)
        {
            try
            {
                var categoria = categoriaApplication.GetById(id);

                if (!isInclude)
                {
                    categoria.Receitas = null;
                }

                var resposta = new ResponsePadrao<CategoriaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria.",
                    ObjetoRetorno = new ResponseObjeto<CategoriaDTO>
                    {
                        Objeto = categoria
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaDTO>
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
        public ActionResult Post([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                var categoriaRetorno = categoriaApplication.Add(categoriaDTO);

                var resposta = new ResponsePadrao<CategoriaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria cadastrada com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaDTO>
                    {
                        Objeto = categoriaRetorno
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaDTO>
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
        public ActionResult Put([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                var categoriaRetorno = categoriaApplication.Update(categoriaDTO);

                var resposta = new ResponsePadrao<CategoriaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaDTO>
                    {
                        Objeto = categoriaRetorno
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaDTO>
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
                var categoria = categoriaApplication.Remove(id);

                var resposta = new ResponsePadrao<CategoriaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<CategoriaDTO>
                    {
                        Objeto = categoria
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<CategoriaDTO>
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
