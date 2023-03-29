using ApiBaseReceitas.application.DTOs;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.Domain.Entities;
using ApiBaseReceitas.Infrastructure.CrossCutting.Response;
using Microsoft.AspNetCore.Mvc;

namespace ApiBaseReceitas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModoPreparoController : Controller
    {
        private readonly IModoPreparoApplication modoPreparoApplication;

        public ModoPreparoController(IModoPreparoApplication modoPreparoApplication)
        {
            this.modoPreparoApplication = modoPreparoApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var modosPreparo = modoPreparoApplication.GetAll();
     
                var resposta = new ResponsePadrao<ModoPreparoDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Modo de Preparo.",
                    ObjetoRetorno = new ResponseObjeto<ModoPreparoDTO>
                    {
                        Lista = modosPreparo
                    }
                };

                return Ok(resposta);
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ModoPreparoDTO>
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
                var modoPreparo = modoPreparoApplication.GetById(id);

                var resposta = new ResponsePadrao<ModoPreparoDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Modo de Preparo.",
                    ObjetoRetorno = new ResponseObjeto<ModoPreparoDTO>
                    {
                        Objeto = modoPreparo
                    }
                };

                return Ok(resposta);

            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ModoPreparoDTO>
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
        public ActionResult Post([FromBody] ModoPreparoDTO modoPreparoDTO)
        {
            try
            {
                if (modoPreparoDTO == null)
                    return NotFound();

                var modoPreparo =  modoPreparoApplication.Add(modoPreparoDTO);

                var resposta = new ResponsePadrao<ModoPreparoDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Modo Preparo Cadastrado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ModoPreparoDTO>
                    {
                        Objeto = modoPreparo
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ModoPreparoDTO>
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
        public ActionResult Put([FromBody] ModoPreparoDTO modoPreparoDTO)
        {
            try
            {
                if (modoPreparoDTO == null)
                    return NotFound();

                var modoPreparo =  modoPreparoApplication.Update(modoPreparoDTO);

                var resposta = new ResponsePadrao<ModoPreparoDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Modo Preparo Atualizado com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ModoPreparoDTO>
                    {
                        Objeto = modoPreparo
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ModoPreparoDTO>
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
                var modoPreparo = modoPreparoApplication.Remove(id);

                var resposta = new ResponsePadrao<ModoPreparoDTO>
                {
                    IsOk = true,
                    IsErro = false,
                    Mensagem = "Modo Preparo Removido com sucesso!",
                    ObjetoRetorno = new ResponseObjeto<ModoPreparoDTO>
                    {
                        Objeto = modoPreparo
                    }
                };

                return Ok(resposta);                
            }
            catch (Exception ex)
            {

                var resposta = new ResponsePadrao<ModoPreparoDTO>
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
