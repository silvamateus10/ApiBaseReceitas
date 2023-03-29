using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Entities;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IngredienteController : Controller
    {
        private readonly IIngredienteApplication ingredienteApplication;

        public IngredienteController(IIngredienteApplication ingredienteApplication)
        {
            this.ingredienteApplication = ingredienteApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var ingredientes = ingredienteApplication.GetAll();

                var resposta = new ResponsePadrao<IngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Ingredientes.",
                    ObjetoRetorno = new ResponseObjeto<IngredienteDTO>
                    {
                        Lista = ingredientes
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<IngredienteDTO>
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
                var ingrediente = ingredienteApplication.GetById(id);

                var resposta = new ResponsePadrao<IngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Ingrediente.",
                    ObjetoRetorno = new ResponseObjeto<IngredienteDTO>
                    {
                        Objeto = ingrediente
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<IngredienteDTO>
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
        public ActionResult Post([FromBody] IngredienteDTO ingredienteDTO)
        {
            try
            {
                if (ingredienteDTO == null)
                    return NotFound();

                var ingrediente =  ingredienteApplication.Add(ingredienteDTO);
                var resposta = new ResponsePadrao<IngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Ingrediente Cadastrado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<IngredienteDTO>
                    {
                        Objeto = ingrediente
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<IngredienteDTO>
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
        public ActionResult Put([FromBody] IngredienteDTO ingredienteDTO)
        {
            try
            {
                if (ingredienteDTO == null)
                    return NotFound();

                var ingrediente =  ingredienteApplication.Update(ingredienteDTO);
                var resposta = new ResponsePadrao<IngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Ingrediente Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<IngredienteDTO>
                    {
                        Objeto = ingrediente
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<IngredienteDTO>
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
                var ingrediente =  ingredienteApplication.Remove(id);
                var resposta = new ResponsePadrao<IngredienteDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Ingrediente Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<IngredienteDTO>
                    {
                        Objeto = ingrediente
                    }
                };

                return Ok(resposta);
                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<IngredienteDTO>
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
