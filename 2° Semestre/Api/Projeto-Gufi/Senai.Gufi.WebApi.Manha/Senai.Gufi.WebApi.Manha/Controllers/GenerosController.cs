using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using Senai.Gufi.WebApi.Manha.Repositories;

namespace Senai.Gufi.WebApi.Manha.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private IGeneroRepository _generoRepository { get; set; }

        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_generoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_generoRepository.BuscarporId(id));
        }

        [HttpPost]
        public IActionResult Post(Generos novoEvento)
        {
            _generoRepository.Cadastrar(novoEvento);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Generos EventoAtualizado)
        {
            try
            {
                _generoRepository.Atualizar(id, EventoAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _generoRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}