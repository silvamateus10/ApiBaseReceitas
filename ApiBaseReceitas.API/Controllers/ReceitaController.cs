using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Entities;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReceitaController : Controller
    {
        private readonly IReceitaApplication receitaApplication;

        public ReceitaController(IReceitaApplication receitaApplication)
        {
            this.receitaApplication = receitaApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var receitas = receitaApplication.GetAll();

                var resposta = new ResponsePadrao<ReceitaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Receitas.",
                    ObjetoRetorno = new ResponseObjeto<ReceitaDTO>
                    {
                        Lista = receitas

                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ReceitaDTO>
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
                var receita = receitaApplication.GetById(id);

                var resposta = new ResponsePadrao<ReceitaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Receita.",
                    ObjetoRetorno = new ResponseObjeto<ReceitaDTO>
                    {
                        Objeto = receita
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ReceitaDTO>
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
        public ActionResult Post([FromBody] ReceitaDTO receitaDTO)
        {
            try
            {
                if (receitaDTO == null)
                    return NotFound();

                var receitaRetorno = receitaApplication.Add(receitaDTO);

                var resposta = new ResponsePadrao<ReceitaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Receita Cadastrado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ReceitaDTO>
                    {
                        Objeto = receitaRetorno
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ReceitaDTO>
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
        public ActionResult Put([FromBody] ReceitaDTO receitaDTO)
        {
            try
            {
                if (receitaDTO == null)
                    return NotFound();

                var receita = receitaApplication.Update(receitaDTO);

                var resposta = new ResponsePadrao<ReceitaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Receita Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ReceitaDTO>
                    {
                        Objeto = receita
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ReceitaDTO>
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
                var receita = receitaApplication.Remove(id);

                var resposta = new ResponsePadrao<ReceitaDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Receita Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ReceitaDTO>
                    {
                        Objeto = receita
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ReceitaDTO>
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
