using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repositories;

namespace Senai.InLock.WebApi.DataBaseFirst.Controllers
{
   [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class JogosController : ControllerBase
    {
        private IJogoRepository _jogosrepository;

        public JogosController()
        {
            _jogosrepository = new JogoRepository();
        }

        [HttpGet]
        public IActionResult Get(Jogos jogo)
        {
            return Ok(_jogosrepository.Listar());
        }

        [HttpGet("id")]
        public IActionResult GetporId(int id, Jogos jogo)
        {
            return Ok(_jogosrepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Jogos addjogo)
        {
            _jogosrepository.Cadastrar(addjogo);
            return StatusCode(201);
        }

        [HttpPut]
        public IActionResult Put(int id , Jogos attJogo)
        {
            _jogosrepository.Atualizar(id , attJogo);
            return Ok($"Jogo {attJogo.IdJogo} atualizado com sucesso ");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _jogosrepository.Delete(id);
            return Ok("Jogo deletado com sucesso");
        }


    }
}


   

   

   