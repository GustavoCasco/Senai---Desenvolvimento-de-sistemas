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
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private IFilmesRepository _filmeRepository { get; set; }

        public FilmesController ()
        {
            _filmeRepository = new FilmeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_filmeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_filmeRepository.BuscarporId (id));
        }

        [HttpPost]
        public IActionResult Post(Filmes novoEvento)
        {
            _filmeRepository.Cadastro(novoEvento);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Filmes EventoAtualizado)
        {
            try
            {
                _filmeRepository.Atualizar(id, EventoAtualizado);

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
            _filmeRepository.Delete(id);

            return StatusCode(204);
        }
    }
}