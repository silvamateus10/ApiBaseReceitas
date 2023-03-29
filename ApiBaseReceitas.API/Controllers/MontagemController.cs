using ApiBaseReceitas.application;
using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Entities;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MontagemController : Controller
    {
        private readonly IMontagemApplication montagemApplication;

        public MontagemController(IMontagemApplication montagemApplication)
        {
            this.montagemApplication = montagemApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var montagens = montagemApplication.GetAll();


                var resposta = new ResponsePadrao<MontagemDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categorias.",
                    ObjetoRetorno = new ResponseObjeto<MontagemDTO>
                    {
                        Lista = montagens
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<MontagemDTO>
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
                var montagem = montagemApplication.GetById(id);


                var resposta = new ResponsePadrao<MontagemDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Categoria.",
                    ObjetoRetorno = new ResponseObjeto<MontagemDTO>
                    {
                        Objeto = montagem
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<MontagemDTO>
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
        public ActionResult Post([FromBody] MontagemDTO montagemDTO)
        {
            try
            {
                if (montagemDTO == null)
                    return NotFound();

                var montagem = montagemApplication.Add(montagemDTO);

                var resposta = new ResponsePadrao<MontagemDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Montagem Cadastrado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<MontagemDTO>
                    {
                        Objeto = montagem
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<MontagemDTO>
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
        public ActionResult Put([FromBody] MontagemDTO montagemDTO)
        {
            try
            {
                if (montagemDTO == null)
                    return NotFound();

                var montagem = montagemApplication.Update(montagemDTO);

                var resposta = new ResponsePadrao<MontagemDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Montagem Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<MontagemDTO>
                    {
                        Objeto = montagem
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<MontagemDTO>
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
                var montagem = montagemApplication.Remove(id);

                var resposta = new ResponsePadrao<MontagemDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Montagem Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<MontagemDTO>
                    {
                        Objeto = montagem
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<MontagemDTO>
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
